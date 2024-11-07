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
    /// Interaction logic for W_Admin.xaml
    /// </summary>
    public partial class W_Admin : Window
    {
        private readonly P_CustomerManagement customerManagementPage;
        private readonly P_OrderManagement orderHistory;
        private readonly P_Static sstatic;

        public W_Admin()
        {
            InitializeComponent();

            customerManagementPage = new P_CustomerManagement();
            orderHistory = new P_OrderManagement();
            sstatic = new P_Static();
        }

        private void TabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (ContentFrame == null) return;

            var selectedTab = (sender as TabControl)?.SelectedIndex;

            switch (selectedTab)
            {
                case 0:
                    ContentFrame.Navigate(customerManagementPage);
                    break;
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    ContentFrame.Navigate(orderHistory);
                    break;
                case 4:
                    ContentFrame.Navigate(sstatic);
                    break;
                case 5:
                    
                    Login loginWindow = new Login();
                    loginWindow.Show();
                    this.Close();
                    break;
                case 6:
                    this.Close();
                    break;
            }
        }
    }
}
