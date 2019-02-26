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
    /// Interaction logic for ViewProfilePage.xaml
    /// </summary>
    public partial class ViewProfilePage : Page
    {
        List<Loan> temp = new List<Loan>();
        public ViewProfilePage()
        {
            InitializeComponent();
            //Console.WriteLine(Main.customerSelected.Firstname);
            //Console.WriteLine(Main.customerSelected.MyReceipts[0].MyLoans[0]);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lbxReceipts.ItemsSource = Main.SelectedCustomer.MyReceipts;
            
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void LbxReceipts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Receipt selected = lbxReceipts.SelectedItem as Receipt;           

            if(selected != null)
            {
                lbxLoans.ItemsSource = selected.MyLoans;
                
            }
        }
    }
}
