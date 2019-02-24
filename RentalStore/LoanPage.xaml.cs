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
        List<Movie> Basket = new List<Movie>();
        List<Movie> TempStock = new List<Movie>();
        private int days = 0;

        public LoanPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TempStock = DataRepo.InStock;

            lbxBasket.ItemsSource = Basket;
            lbxStock.ItemsSource = TempStock;
            tblkDays.Text = days.ToString();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Movie selected = lbxStock.SelectedItem as Movie;

            if (selected != null)
            {
                Basket.Add(selected);
                TempStock.Remove(selected);
                DataRepo.UpdateStockRemove(selected);

                lbxStock.ItemsSource = null;
                lbxStock.ItemsSource = TempStock;
                lbxBasket.ItemsSource = null;
                lbxBasket.ItemsSource = Basket;
            }
        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Movie selected = lbxBasket.SelectedItem as Movie;

            if (selected != null)
            {
                TempStock.Add(selected);
                Basket.Remove(selected);
                DataRepo.UpdateStockAdd(selected);

                lbxStock.ItemsSource = null;
                lbxStock.ItemsSource = TempStock;
                lbxBasket.ItemsSource = null;
                lbxBasket.ItemsSource = Basket;
            }
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
            if (Basket.Capacity != 0 && days != 0)
            {
                Loan NewLoan = new Loan(Basket, days);

                NewLoan.DateReturn();
                NewLoan.Cost();

                //DataRepo.InStock = TempStock;

                this.NavigationService.Navigate(new ReceiptPage(NewLoan));
            }
            else
                MessageBox.Show("You have to select at least one movie and rent for at least one day");
        }

    }
}
