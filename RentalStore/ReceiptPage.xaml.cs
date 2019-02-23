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
        private static List<Loan> TempLoans = new List<Loan>();
        private static int count = 0;

        public ReceiptPage()
        {
            InitializeComponent();
        }

        public ReceiptPage(Loan loan):this()
        {
            TempLoans.Add(loan);
            if(count == 1)
            {
                foreach (var item in TempLoans)
                {
                    Console.WriteLine(item.Days);
                }
            }
            count++;
        }

        private void BtnAddAnother_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LoanPage());
        }

        private void BtnFinish_Click(object sender, RoutedEventArgs e)
        {
            Receipt CustomerReceipt = new Receipt(TempLoans);

            foreach (Loan loan in CustomerReceipt.MyLoans)
            {
                Console.WriteLine(loan.Price);
            }
            DataRepo.SelectedCustomer.MyReceipts.Add(CustomerReceipt);
            //Console.WriteLine(Main.customerSelected.MyReceipts[0].MyLoans[0].Price);

            this.NavigationService.Navigate(new Main());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {           
            tblkTotalCost.Text = TotalCost().ToString();
        }

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
