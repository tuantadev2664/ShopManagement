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
using Color = BusinessObjects.Color;
using Size = BusinessObjects.Size;

namespace ShopWPFApp
{
    /// <summary>
    /// Interaction logic for W_AddToCart.xaml
    /// </summary>
    public partial class W_AddToCart : Window
    {
        private readonly Product product;
        private readonly IProductDetailRepository productDetailRepository;
        private readonly P_Shopping p_Shopping;

        public static event EventHandler<OrderDetail> OnGoToOrderDetail;

        public W_AddToCart(Product product, P_Shopping p_Shopping)
        {
            InitializeComponent();

            this.product = product;
            this.p_Shopping = p_Shopping;

            productDetailRepository = new ProductDetailRepository();


            this.DataContext = new
            {
                ImageSource = product.ProductImage
            };
            
            tb_ProductId.Text = product.ProductId.ToString();
            tb_ProductDescription.Text = product.ProductDescription;
            tb_Name.Text = product.ProductName.ToString();
            tb_Price.Text = "$"+product.ProductPrice.ToString();

            cb_Color.ItemsSource = Enum.GetValues(typeof(Color));
            cb_Size.ItemsSource = Enum.GetValues(typeof(Size));
        }

        private void btn_choose(object sender, RoutedEventArgs e)
        {
            if (!IsAllTextboxEntered())
            {
                MessageBox.Show("Please choose Color and Size, Quantity!");
                return;
            }

            int quantity;
            try
            {
                quantity = int.Parse(tb_Quantity.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }


            Color color = (Color)cb_Color.SelectedItem;
            Size size = (Size)cb_Size.SelectedItem;
            int productId = Convert.ToInt32(tb_ProductId.Text);

            var productDetail = productDetailRepository.GetProductDetailById(pd => pd.ProductId == productId && pd.Color == color && pd.Size == size);

            if(productDetail.Stock < quantity)
            {
                MessageBox.Show($"Not enought! Quanity <= {productDetail.Stock}");
                return;
            }
            productDetail.Product = product;

            OrderDetail newOrderDetail = new OrderDetail
            {
                ProductDetailId = productDetail.ProductDetailId,
                Quantity = quantity,
                ActualPrice = product.ProductPrice * quantity,
                ProductDetail = productDetail,
            };

            OnGoToOrderDetail?.Invoke(this, newOrderDetail);
            this.Close();

        }

        private void btn_cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool IsAllTextboxEntered()
        {
            if (string.IsNullOrEmpty(tb_Quantity.Text)) return false;
            if (string.IsNullOrEmpty(cb_Color.Text)) return false;
            if (string.IsNullOrEmpty(cb_Size.Text)) return false;
            return true;
        }
    }
}
