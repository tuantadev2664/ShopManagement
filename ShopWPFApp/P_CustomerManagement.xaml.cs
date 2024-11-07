using BusinessObjects;
using Repositories;
using System;
using System.Collections;
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
    /// Interaction logic for P_CustomerManagement.xaml
    /// </summary>
    public partial class P_CustomerManagement : Page
    {
        private Customer currentSelect;
        private readonly ICustomerRepository customerRepository;

        public P_CustomerManagement()
        {
            InitializeComponent();

            customerRepository = new CustomerRepository();
            UpdateDataGrid();
        }

        public void UpdateDataGrid()
        {
            dataGrid.ItemsSource = customerRepository.GetAllCustomers();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is DataGrid dataGrid)
            {
                var selectedEntiry = dataGrid.SelectedItem as Customer;

                if (selectedEntiry != null)
                {

                    tbId.Text = selectedEntiry.CustomerId.ToString();
                    tbFullName.Text = selectedEntiry.CustomerName;
                    tbTelephone.Text = selectedEntiry.Phone;
                    tbEmail.Text = selectedEntiry.Email;
                    tbAddress.Text = selectedEntiry.Address.ToString();
                    tbStatus.Text = selectedEntiry.CustomerStatus.ToString();

                    currentSelect = selectedEntiry;
                    if (selectedEntiry.CustomerStatus.ToString() == CustomerStatus.Active.ToString())
                    {
                        btn_SwitchStatus.Content = CustomerStatus.Deleted.ToString();
                    }
                    else
                    {
                        btn_SwitchStatus.Content = CustomerStatus.Active.ToString();
                    }
                }
            }
        }

        private void btn_Delete(object sender, RoutedEventArgs e)
        {
            if (currentSelect == null) return;

            if (btn_SwitchStatus.Content.ToString() == CustomerStatus.Active.ToString())
            {
                btn_SwitchStatus.Content = CustomerStatus.Deleted.ToString();
                var customer = customerRepository.GetCustomerById(x => x.CustomerId == currentSelect.CustomerId);
                if (customer != null)
                {
                    try
                    {
                        customer.CustomerStatus = CustomerStatus.Active;

                        customerRepository.UpdateCustomer(customer);
                        tbStatus.Text = currentSelect.CustomerStatus.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
               
            }
            else
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    btn_SwitchStatus.Content = CustomerStatus.Active.ToString();
                    var customer = customerRepository.GetCustomerById(x => x.CustomerId == currentSelect.CustomerId);
                    if (customer != null)
                    {
                        try
                        {
                            customer.CustomerStatus = CustomerStatus.Deleted;

                            customerRepository.UpdateCustomer(customer);
                            tbStatus.Text = currentSelect.CustomerStatus.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                    
                }
            }
            UpdateDataGrid();
        }

        private void btn_SearchByName(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchbyText.Text))
            {
                UpdateDataGrid();
            }
            else
            {
                dataGrid.ItemsSource = customerRepository.GetAllCustomers().Where(c =>
                    c.CustomerName.ToLower().Contains(tbSearchbyText.Text.ToLower()));
            }
        }

    }
}
