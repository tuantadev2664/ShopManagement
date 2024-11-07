using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ShopWPFApp
{
    /// <summary>
    /// Interaction logic for W_UpdateOrderDetail.xaml
    /// </summary>
    public partial class W_UpdateOrderDetail : Window
    {
        private readonly P_Cart p_Cart;
        private readonly OrderDetail orderDetail;
        private readonly IProductDetailRepository productDetailRepository;

        public W_UpdateOrderDetail(OrderDetail orderDetail, P_Cart p_Cart)
        {
            InitializeComponent();

            productDetailRepository = new ProductDetailRepository();

            this.p_Cart = p_Cart;
            this.orderDetail = orderDetail;

            tbQuantity.Text = orderDetail.Quantity.ToString();

        }

        private void btn_submit(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbQuantity.Text))
            {
                MessageBox.Show("Please Enter Quantity!");
                return;
            }

            foreach(var item in P_Cart.OrderDetails)
            {
                if(item.ProductDetailId == orderDetail.ProductDetailId)
                {
                    item.Quantity = Convert.ToInt32(tbQuantity.Text);
                    item.ActualPrice = item.Quantity * item.ProductDetail.Product.ProductPrice;
                    if (item.Quantity > productDetailRepository.GetProductDetailById(p => p.ProductDetailId == item.ProductDetailId).Stock)
                    {
                        MessageBox.Show($"Not Enough! Quantity <= {productDetailRepository.GetProductDetailById(p => p.ProductDetailId == item.ProductDetailId).Stock}");
                        return;
                    }

                    break;
                }

                
            }

            MessageBox.Show("Update Order Detail Succesfully!");
            p_Cart.UpdateDataGrid();
            p_Cart.UpdateOrderDetailVMSelected();
            this.Close();
        }

        private void btn_cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
