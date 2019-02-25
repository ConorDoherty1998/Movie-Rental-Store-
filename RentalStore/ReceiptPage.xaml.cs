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
        public static List<Loan> TempLoans = new List<Loan>();
        public List<Loan> TempLoans2 = new List<Loan>();

        public ReceiptPage()
        {
            InitializeComponent();           
        }

        public ReceiptPage(Loan loan):this()
        {
            TempLoans.Add(loan);
        }

        private void BtnAddAnother_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LoanPage());
        }

        private void BtnFinish_Click(object sender, RoutedEventArgs e)
        {
            Receipt CustomerReceipt = new Receipt(TempLoans, TotalCost());
         
            Main.customerSelected.MyReceipts.Add(CustomerReceipt);

            //Console.WriteLine(Main.customerSelected.MyReceipts[0].MyLoans[0]);
            //TempLoans.Clear();

            foreach (var item in TempLoans2)
            {
                Console.WriteLine(item);
            }
            this.NavigationService.Navigate(new Main());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lbxLoans.ItemsSource = TempLoans;
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
