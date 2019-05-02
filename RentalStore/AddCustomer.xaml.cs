using MaterialDesignThemes.Wpf;
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
            lbxCustomers.ItemsSource = DataRepo.CurrentCustomers;
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
                //var myMessageQueue = new SnackbarMessageQueue(TimeSpan.FromMilliseconds(8000));
                //MySnackbar.MessageQueue = myMessageQueue;

                //var messageQue = MySnackbar.MessageQueue;
                //var message = "Created Customer " + txtbxFirstName.Text;

                //Task.Factory.StartNew(() => messageQue.Enqueue(message));
                Refresh();
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

        private void BtnReturn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Main());
        }

        private void BtnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Customer temp = button.DataContext as Customer;
            DataRepo.CurrentCustomers.Remove(temp);
            Refresh();
        }
        private void Refresh()
        {
            lbxCustomers.ItemsSource = null;
            lbxCustomers.ItemsSource = DataRepo.CurrentCustomers;
        }
    }
}
