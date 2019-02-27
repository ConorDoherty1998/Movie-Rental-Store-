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
        List<Movie> TempStock = new List<Movie>();
        private int days = 0;

        public LoanPage()
        {
            InitializeComponent();
        }

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
        private void btnDecrease_Click(object sender, RoutedEventArgs e)
        {
            if (days != 0)
            {
                days--;
                tblkDays.Text = days.ToString();
            }
        }
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Movie selected = lbxStock.SelectedItem as Movie;
            if (selected != null && days != 0)
            {
                DataRepo.UpdateStockRemove(selected);

                Loan NewLoan = new Loan(selected, days);
                NewLoan.DateReturn();
                NewLoan.Cost();

                DataRepo.AllLoans.Add(NewLoan);

                DataRepo.InStock = TempStock;

                this.NavigationService.Navigate(new ReceiptPage(NewLoan));
            }
            else
                MessageBox.Show("You have to select at least one movie and rent for at least one day");
        }

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
