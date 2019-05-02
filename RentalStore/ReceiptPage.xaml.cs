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
    /// Interaction logic for ReceiptPage.xaml
    /// </summary>
    public partial class ReceiptPage : Page
    {
        Customer Selected = new Customer();
        public static List<Loan> TempLoans = new List<Loan>();// just to display to user from page to page
        private List<Loan> LoansAddedToReceipt = new List<Loan>(); // the final loans with will be added to the receipt

        public ReceiptPage()
        {
            InitializeComponent();           
        }

        public ReceiptPage(Loan loan, Customer selected):this()
        {
            TempLoans.Add(loan);
            Selected = selected;
        }

        private void BtnAddAnother_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LoanPage());
            this.NavigationService.Navigate(new LoanPage(Selected));
        }

        // loans and total cost added to a receipt and that receipt is then added to the current selected customer
        private void BtnFinish_Click(object sender, RoutedEventArgs e)
        {
            foreach (Loan loan in TempLoans)
            {
                LoansAddedToReceipt.Add(loan);
            }
            Receipt CustomerReceipt = new Receipt(LoansAddedToReceipt, TotalCost());        
            Selected.MyReceipts.Add(CustomerReceipt);

            TempLoans.Clear();

            this.NavigationService.Navigate(new Main());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lbxLoans.ItemsSource = TempLoans;
            tblkTotal.Text = $"Total Cost: €{TotalCost().ToString()}";

        }

        //getting total cost of all loans whenever the page loads
        private decimal TotalCost()
        {
            decimal total = 0;

            foreach (Loan loan in TempLoans)
            {
                total += loan.Price;
            }

            return total;
        }
    }
}
