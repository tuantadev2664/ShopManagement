using BusinessObjects;
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
    /// Interaction logic for W_Customer.xaml
    /// </summary>
    public partial class W_Customer : Window
    {
        private readonly P_Shopping p_Shopping;
        private readonly P_Cart p_Cart;
        private readonly P_CustomerProfile p_CustomerProfile;
        private readonly P_OrderHistory p_OrderHistory;


        private EventHandler<OrderDetail> orderHandler;

        public W_Customer(Customer customer)
        {
            InitializeComponent();

            p_Shopping = new P_Shopping();
            p_Cart = new P_Cart(null, customer);
            p_CustomerProfile = new P_CustomerProfile(customer);
            p_OrderHistory = new P_OrderHistory(customer);


            orderHandler += (sender, data) =>
            {
                tabControl.SelectedIndex = 2;
                ContentFrame.Navigate(new P_Cart(data, customer));
            };
            W_AddToCart.OnGoToOrderDetail += orderHandler;
        }

        private void TabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (ContentFrame == null) return;

            var selectedTab = (sender as TabControl)?.SelectedIndex;

            switch (selectedTab)
            {
                case 0:
                    ContentFrame.Navigate(p_CustomerProfile);
                    break;
                case 1:
                    ContentFrame.Navigate(p_Shopping);
                    break;
                case 2:
                    ContentFrame.Navigate(p_Cart);
                    break;
                case 3:
                    ContentFrame.Navigate(p_OrderHistory);
                    break;
                case 4:
                    p_Cart.ResetOrderDetail();
                    Login loginWindow = new Login();
                    loginWindow.Show();
                    this.Close();
                    break;
                case 5:
                    this.Close();
                    break;
            }
        }
    }
}
