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
    /// Interaction logic for Checkout.xaml
    /// </summary>
    public partial class Checkout : Page
    {
        private Customer Selected = new Customer();
        private decimal totalCost = new decimal();
        private List<Loan> loans = new List<Loan>();
        private List<Loan> myLoans = new List<Loan>();
        public Checkout()
        {
            InitializeComponent();
        }

        public Checkout(Customer selected) : this()
        {
            Selected = selected;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i< DataRepo.InStock.Count(); i++)
            {
                Loan temp = new Loan();
                temp.MyMovie = DataRepo.InStock[i];
                loans.Add(temp);
            }
            Refresh();
        }

        private void BtnIncrease_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Loan tempLoan = button.DataContext as Loan;
            if (tempLoan.Days != 21)
            {
                loans.Find(x => x.MyMovie.Title == tempLoan.MyMovie.Title).Days++;
                Refresh();
            }
            else
                MessageBox.Show("You can only rent a movie for a maximum of 3 weeks");
        }

        private void BtnDecrease_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Loan tempLoan = button.DataContext as Loan;

            if (tempLoan.Days != 1)
            {
                loans.Find(x => x.MyMovie.Title == tempLoan.MyMovie.Title).Days--;
                Refresh();
            }
            else
                MessageBox.Show("You cannot loan a movie for less than one day");
            
        }

        private void LbxMovies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxMovies.SelectedItem != null)
            {
                Loan temp = lbxMovies.SelectedItem as Loan;
                tblkDesc.Text = temp.MyMovie.Description;
            }
        }

        private void BtnLoanMovie_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Loan temp = button.DataContext as Loan;

            if (temp.MyMovie.Copies != 0)
            {
                Loan newLoan = new Loan();
                newLoan.MyMovie = temp.MyMovie;
                newLoan.Days = temp.Days;

                newLoan.Price = temp.Days * temp.MyMovie.PricePerDay;
                newLoan.ReturnDate = DateTime.Now.AddDays(temp.Days);

                DataRepo.UpdateStockRemove(newLoan.MyMovie);

                totalCost += newLoan.Price;
                myLoans.Add(newLoan);
                Refresh();
            }
            else
                MessageBox.Show("No Copies Left");
        }

        private void BtnCancelLoan_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Loan temp = button.DataContext as Loan;
            DataRepo.UpdateStockAdd(temp.MyMovie);

            totalCost -= temp.Price;
            myLoans.Remove(temp);
            Refresh();
        }

        private void Refresh()
        {
            lbxMovies.ItemsSource = null;
            lbxMovies.ItemsSource = loans.OrderBy(x => x.MyMovie.Title);

            lbxLoans.ItemsSource = null;
            lbxLoans.ItemsSource = myLoans.OrderBy(x => x.MyMovie.Title);
            tbxTotalCost.Text = ("€" + totalCost.ToString("0.00"));
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (var i in lbxLoans.Items)
            {
                Loan temp = i as Loan;
                DataRepo.UpdateStockAdd(temp.MyMovie);
            }
            lbxLoans.ItemsSource = null;
            totalCost = 0m;
            myLoans.Clear();
            Refresh();
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            List<Loan> tempLoans = new List<Loan>();
            if (myLoans.Count != 0) 
            {
                foreach (var i in lbxLoans.Items)
                {
                    Loan tempLoan = i as Loan;
                    DataRepo.AllLoans.Add(tempLoan);
                    tempLoans.Add(tempLoan);
                }
                Selected.MyReceipts.Add(new Receipt(tempLoans, totalCost));
                this.NavigationService.Navigate(new Main());
            }
            else
                MessageBox.Show("Your basked is empty");
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Main());
        }
    }
}
