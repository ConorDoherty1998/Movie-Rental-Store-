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
        public Main()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lbxCustomers.ItemsSource = DataRepo.GetCustomers();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            DataRepo.SelectedCustomer = lbxCustomers.SelectedItem as Customer;
            Button b = (Button)sender;
            
            if(DataRepo.SelectedCustomer != null)
            {
                if (b.Name == "btnViewProfile")
                {
                    Console.WriteLine("success");
                    this.NavigationService.Navigate(new ViewProfilePage());
                }
                else if (b.Name == "btnCreateLoan")
                {
                    this.NavigationService.Navigate(new LoanPage());
                }
                else if (b.Name == "btnViewStock")
                {
                    this.NavigationService.Navigate(new ViewStockPage());
                }
                else
                    MessageBox.Show("Error");
            }
            else
                MessageBox.Show("Error");
        }
    }
}
