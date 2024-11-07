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
    /// Interaction logic for P_Shopping.xaml
    /// </summary>
    public partial class P_Shopping : Page
    {
        private readonly IProductRepository productRepository;
        public P_Shopping()
        {
            InitializeComponent();

            productRepository = new ProductRepository();
            LoadProductList();

        }

        public void LoadProductList()
        {
            var list = productRepository.GetAllProducts();
            this.DataContext = new
            {
                MyObjectList = list
            };

            cb_Category.ItemsSource = Enum.GetValues(typeof(Category));
        }

        private void btn_Detail(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Truy cập vào CommandParameter để nhận dữ liệu
                var data = button.CommandParameter;

                // Xử lý dữ liệu ở đây
                if (data != null)
                {
                    var product = productRepository.GetProductById(p => p.ProductId == Convert.ToInt32(data));

                    if (product == null) return;
                    var addToCart = new W_AddToCart(product, this);
                    addToCart.Show();
                }
            }
        }

        private void cb_Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var list = productRepository.GetAllProducts().Where(p => p.Category == (Category)cb_Category.SelectedItem);
            this.DataContext = new
            {
                MyObjectList = list
            };

            cb_Category.ItemsSource = Enum.GetValues(typeof(Category));
            
        }
    }
}
