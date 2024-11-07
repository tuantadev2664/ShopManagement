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
using static MaterialDesignThemes.Wpf.Theme;

namespace ShopWPFApp
{
    /// <summary>
    /// Interaction logic for P_Static.xaml
    /// </summary>
    public partial class P_Static : Page
    {
        private DateTime fromDate;
        private DateTime toDate;

        private readonly IOrderRepository orderRepository;

        private static decimal totalRevenue = 0;


        public P_Static()
        {
            InitializeComponent();

            orderRepository = new OrderRepository();

            totalRevenue = 0;

            tb_TotalRevenue.Text = totalRevenue + " $";
        }

        private void Upload()
        {
            if (IsAllTextboxEntered())
            {
                totalRevenue = 0;
                var orders = new ObservableCollection<Order>();

                foreach (var item in orderRepository.GetAllOrders().Where(o => o.OrderStatus == OrderStatus.Confirmed))
                {
                    if (item.OrderDate.CompareTo(DateOnly.FromDateTime(fromDate)) >= 0 && item.OrderDate.CompareTo(DateOnly.FromDateTime(toDate)) <= 0)
                        orders.Add(item);
                }
                dataGrid.ItemsSource = orders;

                foreach (var item in orders)
                {
                    totalRevenue += item.TotalPrice;
                }
                tb_TotalRevenue.Text = totalRevenue + " $";

                if (orders.Count == 0)
                {
                    MessageBox.Show($"Didn't have customer from {DateOnly.FromDateTime(fromDate)} to {DateOnly.FromDateTime(toDate)}!");
                }

            }
            else
            {
                totalRevenue = 0;
                dataGrid.ItemsSource = orderRepository.GetAllOrders().Where(o => o.OrderStatus == OrderStatus.Confirmed);

                foreach (var item in orderRepository.GetAllOrders().Where(o => o.OrderStatus == OrderStatus.Confirmed))
                {
                    totalRevenue += item.TotalPrice;
                }
                tb_TotalRevenue.Text = totalRevenue + " $";
            }

        }


        private void FromDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is DatePicker datePicker && datePicker.SelectedDate.HasValue)
            {
                fromDate = datePicker.SelectedDate.Value;
                DateTime selectedDate = datePicker.SelectedDate.Value;
                //MessageBox.Show($"From Date selected: {selectedDate.ToShortDateString()}");
            }
        }

        private void ToDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is DatePicker datePicker && datePicker.SelectedDate.HasValue)
            {
                toDate = datePicker.SelectedDate.Value;
                DateTime selectedDate = datePicker.SelectedDate.Value;
                //MessageBox.Show($"To Date selected: {selectedDate.ToShortDateString()}");
            }
        }

        private void btn_Sort(object sender, RoutedEventArgs e)
        {
            if (toDate.CompareTo(fromDate) < 0)
            {
                MessageBox.Show($"Invalid Pick Date, try again!");
            }
            else
            {
                Upload();
            }
        }

        private bool IsAllTextboxEntered()
        {
            if (fromDate == DateTime.MinValue && toDate == DateTime.MinValue) return false;
            return true;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
