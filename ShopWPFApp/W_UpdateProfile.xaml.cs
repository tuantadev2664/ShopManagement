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
    /// Interaction logic for W_UpdateProfile.xaml
    /// </summary>
    public partial class W_UpdateProfile : Window
    {
        private readonly ICustomerRepository customerRepository;
        private Customer customer;
        private P_CustomerProfile customerProfile;

        public W_UpdateProfile(Customer customer, P_CustomerProfile customerProfile)
        {
            InitializeComponent();

            this.customer = customer;
            this.customerProfile = customerProfile;

            customerRepository = new CustomerRepository();

            tb_FullName.Text = customer.CustomerName;
            tb_Telephone.Text = customer.Phone;
            tb_EmailAddress.Text = customer.Email;
            tbAddress.Text = customer.Address;


        }

        private void btn_submit(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!IsAllTextboxEntered())
                {
                    MessageBox.Show("Please input all fields!");
                    return;
                }

                string fullName = tb_FullName.Text.Trim();
                string telephone = tb_Telephone.Text.Trim();
                string address = tbAddress.Text.Trim();

                if (fullName.Length < 3 || fullName.Length > 50)
                {
                    MessageBox.Show("Full Name must be between 3 and 50 characters.");
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(telephone, @"^\d{10,15}$"))
                {
                    MessageBox.Show("Telephone must be a number between 10 and 15 digits.");
                    return;
                }


                customer.CustomerName = fullName;
                customer.Phone = telephone;
                customer.Address = address;
                customerRepository.UpdateCustomer(customer);

                MessageBox.Show("Profile updated successfully!");
                customerProfile.UpdateVisual();
                this.Close();
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

        private bool IsAllTextboxEntered()
        {
            if (string.IsNullOrEmpty(tb_FullName.Text)) return false;
            if (string.IsNullOrEmpty(tb_Telephone.Text)) return false;
            if (string.IsNullOrEmpty(tb_EmailAddress.Text)) return false;
            if (string.IsNullOrEmpty(tbAddress.Text)) return false;
            return true;
        }
    }
}
