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
    /// Interaction logic for W_ChangePassword.xaml
    /// </summary>
    public partial class W_ChangePassword : Window
    {
        private Customer customer;
        private readonly ICustomerRepository customerRepository;

        public W_ChangePassword(Customer customer)
        {
            InitializeComponent();


            this.customer = customer;

            customerRepository = new CustomerRepository();
        }

        private void btn_submit(object sender, RoutedEventArgs e)
        {
            try
            {
                string oldPass = pbOldPassword.Password;
                string newPass = pbNewPassword.Password;
                string confirmNewPass = pbReNewPassword.Password;

                if (newPass.Equals(oldPass))
                {
                    MessageBox.Show("New password equal Old password, please input new password!");
                }
                else if (!newPass.Equals(confirmNewPass))
                {
                    MessageBox.Show("Confirm password invalid, please input again!");
                }
                else
                {
                    customer.Password = newPass;
                    customerRepository.UpdateCustomer(customer);
                    MessageBox.Show("Update Password Successfully!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void btn_cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
