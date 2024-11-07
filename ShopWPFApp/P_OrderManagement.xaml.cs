using BusinessObjects;
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
    /// Interaction logic for P_OrderManagement.xaml
    /// </summary>
    public partial class P_OrderManagement : Page
    {
        private readonly IOrderRepository orderRepository;

        public P_OrderManagement()
        {
            InitializeComponent();

            orderRepository = new OrderRepository();

            var orderList = new ObservableCollection<Order>(orderRepository.GetAllOrders());

            this.DataContext = new
            {
                orderList = orderList
            };
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Truy cập vào CommandParameter để nhận dữ liệu
                var data = button.CommandParameter;

                // Xử lý dữ liệu ở đây
                if (data != null)
                {
                    var order = orderRepository.GetOrderById(o => o.OrderId == Convert.ToInt32(data));
                    if (order.OrderStatus == OrderStatus.Confirmed)
                        MessageBox.Show("Order is Confirmed");
                    else if (order.OrderStatus == OrderStatus.Pending)
                    {
                        try
                        {
                            order.OrderStatus = OrderStatus.Cancelled;
                            orderRepository.UpdateOrder(order);
                            Upload();
                            MessageBox.Show("Order is Cancelled Successful");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }

                    }

                    else
                    {
                        MessageBox.Show("Order is Cancelled");
                    }
                }
            }
        }

        private void btn_Confirm_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Truy cập vào CommandParameter để nhận dữ liệu
                var data = button.CommandParameter;

                // Xử lý dữ liệu ở đây
                if (data != null)
                {

                    var order = orderRepository.GetOrderById(o => o.OrderId == Convert.ToInt32(data));
                    if (order.OrderStatus == OrderStatus.Confirmed)
                        MessageBox.Show("Order is Confirmed");
                    else if (order.OrderStatus == OrderStatus.Pending)
                    {
                        try
                        {
                            order.OrderStatus = OrderStatus.Confirmed;
                            orderRepository.UpdateOrder(order);
                            Upload();
                            MessageBox.Show("Order is Cancelled Successful");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                    else
                        MessageBox.Show("Order is Cancelled");

                }
            }
        }

        private void Upload()
        {
            var orderList = orderRepository.GetAllOrders();

            this.DataContext = new
            {
                orderList = orderList
            };
        }

        private void btn_Reload_Click(object sender, RoutedEventArgs e)
        {
            Upload();
        }

        private void btn_Search(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchbyText.Text))
            {
                Upload();
            }
            else
            {
                int id;
                try
                {
                    id = int.Parse(tbSearchbyText.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error! Input Invale. Please Enter OrderId Of Customer.");
                    throw;
                }


                var order = orderRepository.GetOrderById(o => o.OrderId == id);

                if (order == null)
                {
                    MessageBox.Show("Not find");
                }
                else
                {
                    this.DataContext = new
                    {
                        orderList = new List<Order>() { order }
                    };

                }
            }

        }
    }
}
