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
    /// Interaction logic for LoanPage.xaml
    /// </summary>
    public partial class LoanPage : Page
    {
        List<Movie> TempStock = new List<Movie>();//tempstock list made so no permanent changes are made to the instock list until create button is clicked
        private int days = 0;//displays how many days the movie is rented for

        public LoanPage()
        {
            InitializeComponent();
        }

        //setting the lbx source and the tblkDays source
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TempStock = DataRepo.InStock;
           
            lbxStock.ItemsSource = TempStock;
            tblkDays.Text = days.ToString();
        }

        private void btnIncrease_Click(object sender, RoutedEventArgs e)
        {
            days++;
            tblkDays.Text = days.ToString();
        }

        //you cannot decrease below zero days
        private void btnDecrease_Click(object sender, RoutedEventArgs e)
        {
            if (days != 0)
            {
                days--;
                tblkDays.Text = days.ToString();
            }
        }

        //when the button is clicked stock is changed and a new loan is created. The new loan is passed through to the ReceiptPage.
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Movie selected = lbxStock.SelectedItem as Movie;
            if (selected != null && days != 0)
            {
                DataRepo.UpdateStockRemove(selected);

                Loan NewLoan = new Loan(selected, days);
                DataRepo.AllLoans.Add(NewLoan);

                DataRepo.InStock = TempStock;

                this.NavigationService.Navigate(new ReceiptPage(NewLoan));
            }
            else
                MessageBox.Show("You have to select at least one movie and rent for at least one day");
        }

        //the description changes based on whatever movie is selected. This is done by changing the Data Context.
        private void lbxStock_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie selected = lbxStock.SelectedItem as Movie;

            if(selected != null)
            {
                loanGrid.DataContext = selected;
            }
        }
    }
}
