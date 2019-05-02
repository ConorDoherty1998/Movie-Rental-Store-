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
            lbxCustomers.ItemsSource = DataRepo.CurrentCustomers;
            lbxMovies.ItemsSource = DataRepo.AllLoans;
        }

        //once a cutomer is selected you can access and ViewProfile Page and you can also access the Loan Page if theres enough movies in stock
        //private void btn_Click(object sender, RoutedEventArgs e)
        //{
        //    SelectedCustomer = lbxCustomers.SelectedItem as Customer;
        //    Button b = (Button)sender;

        //    if (SelectedCustomer != null)
        //    {
        //        if (b.Name == "btnViewProfile")
        //        {
        //            this.NavigationService.Navigate(new ViewProfilePage());
        //        }
        //        else if (b.Name == "btnCreateLoan")
        //        {
        //            if(DataRepo.InStock.Count == 0)
        //            {
        //                MessageBox.Show("All movies are out of stock");
        //            }
        //            else
        //                this.NavigationService.Navigate(new LoanPage());
        //        }
        //    }
        //    else
        //        MessageBox.Show("You must select a customer");
        //}

        //when you select a movie that movie can be returned to the instock list
        private void BtnReturn_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Loan selected = button.DataContext as Loan;
            DataRepo.UpdateStockAdd(selected.MyMovie);
            DataRepo.AllLoans.Remove(selected);

            lbxMovies.ItemsSource = null;
            lbxMovies.ItemsSource = DataRepo.AllLoans;
        }

        private void BtnLoanMovie_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Customer selected = button.DataContext as Customer;
            this.NavigationService.Navigate(new Checkout(selected));
            //if (DataRepo.InStock.Count == 0)
            //    MessageBox.Show("All movies are out of stock");
            //else
            //    this.NavigationService.Navigate(new LoanPage(selected));
        }

        private void BtnCustomerInfo_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Customer selected = button.DataContext as Customer;
            this.NavigationService.Navigate(new ViewProfilePage(selected));
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddCustomer());
        }

        private void TxtbxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filter = txtbxSearch.Text.ToLower();
            if (filter != "search...")
            {
                lbxCustomers.ItemsSource = null;
                lbxCustomers.ItemsSource = DataRepo.CurrentCustomers.Where(x => x.FullName.ToLower().Contains(filter));
            }
            
        }

        private void BtnClearSearch_Click(object sender, RoutedEventArgs e)
        {
            lbxCustomers.Focus();
            lbxCustomers.ItemsSource = DataRepo.CurrentCustomers;
        }
    }
}
