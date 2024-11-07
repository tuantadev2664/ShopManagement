using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShopWPFApp
{
    /// <summary>
    /// Interaction logic for P_Cart.xaml
    /// </summary>
    
    
    public partial class P_Cart : Page
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderDetailRepository orderDetailRepository;
        private readonly IProductDetailRepository productDetailRepository;


        private readonly OrderDetail OrderDetail;

        private decimal totalPrice = 0;
        private OrderDetail currentSelect;
        private Customer Customer;

        public static ObservableCollection<OrderDetail> OrderDetails;

        public P_Cart()
        {
            InitializeComponent();
        }

        public P_Cart(OrderDetail? orderDetail, Customer customer)
        {
            InitializeComponent();
            orderRepository = new OrderRepository();
            orderDetailRepository = new OrderDetailRepository();
            productDetailRepository = new ProductDetailRepository();

            this.Customer = customer;

            if (OrderDetails == null)
            {
                OrderDetails = new ObservableCollection<OrderDetail>();
            }

            if (orderDetail != null)
            {
                var existingItem = OrderDetails.FirstOrDefault(x => x.ProductDetailId == orderDetail.ProductDetailId);
                if (existingItem != null)
                {
                    foreach(var item in OrderDetails)
                    {
                        if(item.ProductDetailId == existingItem.ProductDetailId)
                        {
                            int oldQuantiry = item.Quantity;
                            item.Quantity += orderDetail.Quantity;
                            if (item.Quantity > productDetailRepository.GetProductDetailById(p => p.ProductDetailId == item.ProductDetailId).Stock)
                            {
                                MessageBox.Show($"Not Enough because exist a item with quantity = {oldQuantiry}! so add Quantity <= {productDetailRepository.GetProductDetailById(p => p.ProductDetailId == item.ProductDetailId).Stock - oldQuantiry}");
                                item.Quantity = oldQuantiry;
                                dataGrid.ItemsSource = OrderDetails;

                                totalPrice = 0;
                                foreach (var item1 in OrderDetails)
                                {
                                    totalPrice += item1.ActualPrice;
                                }
                                tb_TotalPrice.Text = totalPrice.ToString() + " $";
                                return;
                            }

                            item.ActualPrice = item.Quantity * item.ProductDetail.Product.ProductPrice;

                            break;
                        }
                    }
                    MessageBox.Show("Exist! So Quantity will be up");
                }
                else
                {
                    OrderDetails.Add(orderDetail);
                }
                
            }

            dataGrid.ItemsSource = OrderDetails;

            totalPrice = 0;
            foreach (var item in OrderDetails)
            {
                totalPrice += item.ActualPrice;
            }
            tb_TotalPrice.Text = totalPrice.ToString() + " $";
        }

        public void UpdateDataGrid()
        {
            var temp = new ObservableCollection<OrderDetail>();
            totalPrice = 0;

            foreach (var item in OrderDetails)
            {
                temp.Add(item);
                totalPrice += item.ActualPrice;
            }

            tb_TotalPrice.Text = totalPrice.ToString() + " $";

            dataGrid.ItemsSource = temp;
        }

        public void ResetOrderDetail()
        {
            OrderDetails = new ObservableCollection<OrderDetail>();
        }

        public void UpdateOrderDetailVMSelected()
        {
            tbProductDetailId.Text = currentSelect.ProductDetailId.ToString();
            tbName.Text = currentSelect.ProductDetail.Product.ProductName;
            tbPrice.Text = currentSelect.ProductDetail.Product.ProductPrice.ToString();
            tbColor.Text = currentSelect.ProductDetail.Color.ToString();
            tbSize.Text = currentSelect.ProductDetail.Size.ToString();
            tbQuantity.Text = currentSelect.Quantity.ToString();
            tbActualPrice.Text = currentSelect.ActualPrice.ToString();

            this.DataContext = new
            {
                ImageSource = currentSelect.ProductDetail.Product.ProductImage
            };
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (sender is DataGrid dataGrid)
            {
                var selectedEntiry = dataGrid.SelectedItem as OrderDetail;
                if (selectedEntiry != null)
                {
                    tbProductDetailId.Text = selectedEntiry.ProductDetailId.ToString();
                    tbName.Text = selectedEntiry.ProductDetail.Product.ProductName;
                    tbPrice.Text = selectedEntiry.ProductDetail.Product.ProductPrice.ToString() + " $";
                    tbColor.Text = selectedEntiry.ProductDetail.Color.ToString();
                    tbSize.Text =   selectedEntiry.ProductDetail.Size.ToString();
                    tbQuantity.Text = selectedEntiry.Quantity.ToString();
                    tbActualPrice.Text = selectedEntiry.ActualPrice.ToString() + " $";

                    this.DataContext = new
                    {
                        ImageSource = selectedEntiry.ProductDetail.Product.ProductImage
                    };

                    currentSelect = selectedEntiry;
                }
            }
        }

        private void btn_Update(object sender, RoutedEventArgs e)
        {
            if (currentSelect == null)
            {
                MessageBox.Show("Please choose a row!");
                return;
            }
            var updateWindown = new W_UpdateOrderDetail(currentSelect, this);
            updateWindown.Show();
        }

        private void btn_Delete(object sender, RoutedEventArgs e)
        {
            if (currentSelect == null) return;
            MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                OrderDetails.Remove(currentSelect);
            }

            currentSelect = null;
            UpdateDataGrid();
            ResetInput();
         }

        private void btn_CompleteBooking(object sender, RoutedEventArgs e)
        {
            try
            {
                if(totalPrice > 0)
                {
                    Order order = new Order
                    {
                        OrderDate = DateOnly.FromDateTime(DateTime.Now),
                        TotalPrice = totalPrice,
                        CustomerId = Customer.CustomerId,
                        OrderStatus = OrderStatus.Pending,
                    };
                    orderRepository.AddOrder(order);
                    foreach (var item in OrderDetails)
                    {
                        

                        var productDetail = productDetailRepository.GetProductDetailById(p => p.ProductDetailId == item.ProductDetailId);
                        productDetail.Stock = productDetail.Stock - item.Quantity;
                        productDetailRepository.UpdateProductDetail(productDetail);
                    }

                    foreach (var item in OrderDetails)
                    {

                        OrderDetail orderDetail = new OrderDetail
                        {
                            OrderDetailId = item.OrderDetailId,
                            ProductDetailId = item.ProductDetailId,
                            OrderId = order.OrderId,
                            Quantity = item.Quantity,
                            ActualPrice = item.ActualPrice,
                            
                        };
                        orderDetailRepository.AddOrderDetail(orderDetail);

                                             
                    }

                    MessageBox.Show("Order successful");
                    OrderDetails = new ObservableCollection<OrderDetail>();
                    UpdateDataGrid();
                    ResetInput();

                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ResetInput() 
        {
            tbProductDetailId.Text = string.Empty;
            tbName.Text = string.Empty;
            tbPrice.Text = string.Empty;
            tbColor.Text = string.Empty;
            tbSize.Text = string.Empty;
            tbQuantity.Text = string.Empty;
            tbActualPrice.Text = string.Empty;

            this.DataContext = new
            {
                ImageSource = string.Empty
            };
        }


    }
}
