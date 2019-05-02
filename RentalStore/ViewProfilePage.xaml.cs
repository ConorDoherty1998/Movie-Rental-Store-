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
        Customer Selected = new Customer();
        List<Loan> temp = new List<Loan>();
        public ViewProfilePage()
        {
            InitializeComponent();
        }
        public ViewProfilePage(Customer selected) : this()
        {
            Selected = selected;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lbxReceipts.ItemsSource = Selected.MyReceipts;
            txtbxCustomer.Text = $"{Selected.Firstname} {Selected.Lastname}";
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        //displays the loans based on which receipt is selected
        private void LbxReceipts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Receipt selected = lbxReceipts.SelectedItem as Receipt;           

            if(selected != null)
                lbxLoans.ItemsSource = selected.MyLoans;
        }
    }
}
