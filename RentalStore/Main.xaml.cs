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

namespace RentalStore
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public static Customer customerSelected;

        public Main()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lbxCustomers.ItemsSource = DataRepo.GetCustomers();
        }

        private void LbxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customerSelected = lbxCustomers.SelectedItem as Customer;
            Console.WriteLine(customerSelected.Firstname);
        }
    }
}
