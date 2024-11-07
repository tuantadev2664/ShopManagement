using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly ICustomerRepository customerRepository;

        public Login()
        {
            InitializeComponent();

            customerRepository = new CustomerRepository();
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {


            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is empty, please enter!", "Warning");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!", "Warning");
                return;
            }

            string password = txtPassword.Password;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is empty, please enter!", "Warning");
                return;
            }

            //if (customerRepository.GetCustomerById(c => c.Email.Equals(email) && c.Password.Equals(password)) != null)
            //{
            //    W_Admin w_Admin = new W_Admin();
            //    w_Admin.Show();
            //    Close();
            //    return;
            //}

            Customer customer = customerRepository.GetCustomerById(c => c.Email.Equals(email) && c.Password.Equals(password));

            if (customer == null)
            {
                MessageBox.Show("Email or Password wrong!");
                return;
            }
            else
            {
                W_Customer customerWindown = new W_Customer(customer);
                customerWindown.Show();
                Close();
            }
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Login_Admin_Click(object sender, RoutedEventArgs e)
        {
            W_Admin w_Admin = new W_Admin();
            w_Admin.Show();
            Close();
            return;
        }
    }
}
