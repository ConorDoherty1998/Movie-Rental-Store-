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
        public static Customer SelectedCustomer = new Customer();

        public Main()
        {
            InitializeComponent();            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lbxCustomers.ItemsSource = DataRepo.CurrentCustomers;
            lbxMovies.ItemsSource = DataRepo.AllLoans;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            SelectedCustomer = lbxCustomers.SelectedItem as Customer;
            Button b = (Button)sender;

            if (SelectedCustomer != null)
            {
                if (b.Name == "btnViewProfile")
                {
                    this.NavigationService.Navigate(new ViewProfilePage());
                }
                else if (b.Name == "btnCreateLoan")
                {
                    if(DataRepo.InStock.Count == 0)
                    {
                        MessageBox.Show("All movies are out of stock");
                    }
                    else
                        this.NavigationService.Navigate(new LoanPage());
                }
            }
            else
                MessageBox.Show("You must select a customer");
        }

        private void btnViewStock_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ViewStockPage());
        }

        private void BtnReturn_Click(object sender, RoutedEventArgs e)
        {
            Loan selectedLoan = lbxMovies.SelectedItem as Loan;
            if(selectedLoan != null)
            {
                DataRepo.UpdateStockAdd(selectedLoan.MyMovie);
                DataRepo.AllLoans.Remove(selectedLoan);

                lbxMovies.ItemsSource = null;
                lbxMovies.ItemsSource = DataRepo.AllLoans;
            }
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddCustomer());
        }
    }
}
