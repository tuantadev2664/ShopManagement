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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShopWPFApp
{
    /// <summary>
    /// Interaction logic for P_CustomerProfile.xaml
    /// </summary>
    public partial class P_CustomerProfile : Page
    {
        private Customer customer;

        public P_CustomerProfile(Customer customer)
        {
            InitializeComponent();

            this.customer = customer;
            UpdateVisual();

        }

        private void btn_UpdateProfile(object sender, RoutedEventArgs e)
        {
            W_UpdateProfile w_UpdateProfile = new W_UpdateProfile(customer, this);
            w_UpdateProfile.Show();
        }

        private void btn_ChangePassword(object sender, RoutedEventArgs e)
        {
            W_ChangePassword w_ChangePassword = new W_ChangePassword(customer);
            w_ChangePassword.Show();
        }

        public void UpdateVisual()
        {
            tbFullName.Text = customer.CustomerName;
            tbTelephone.Text = customer.Phone;
            tbEmail.Text = customer.Email;
            tbAddress.Text = customer.Address;
        }
    }
}
