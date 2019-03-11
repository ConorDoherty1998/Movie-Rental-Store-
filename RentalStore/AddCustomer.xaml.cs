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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Page
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        //when the button is clicked a customer is added to the customer list
        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            //only if firstname is filled in you can add customer
            if (string.IsNullOrEmpty(txtbxFirstName.Text))
                MessageBox.Show("You must fill in a first name to proceed");
            else
            {
                DataRepo.CurrentCustomers.Add(new Customer(txtbxFirstName.Text, txtbxSurname.Text, txtbxPhoneNumber.Text, txtbxEmailAddress.Text));
                this.NavigationService.Navigate(new Main());
            }
        }

        //when the cancel button is clicked send back to home page
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }
    }
}
