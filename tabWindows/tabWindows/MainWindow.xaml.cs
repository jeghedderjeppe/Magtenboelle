using Event_Oprettelse_Tilmelding;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace tabWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   //liste til at holle alle instanser af Customer klassen
        public List<Customer> customerList = new List<Customer>();
        //liste til at holde alle instanser af CreateEventKlassen
        List<CreateEventClass> eventRservationsListe = new List<CreateEventClass>();
        byte age = 0;
        public MainWindow()
        {
            InitializeComponent();
            
            Customer lars = new Customer("anders", "Odensevej 17", 5000, "Odense", 23, 47583928, "lars@gmail.com");
            Customer jens = new Customer("jens", "Vejlevej 2", 5000, "Odense", 45, 83619374, "jens@gmail.com");
            customerList.Add(lars);
            customerList.Add(jens);
            listBCustomers.ItemsSource = customerList;
        }
		
        //New User Controls....
        private void CbboxNewUserAge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CbboxNewUserAge.SelectedIndex == 0)
            {
                age = 18;
            }
            if (CbboxNewUserAge.SelectedIndex == 1)
            {
                age = 36;
            }
            if (CbboxNewUserAge.SelectedIndex == 2)
            {
                age = 50;
            }
        }

        private void txtNewUserEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNewUserTelehone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNewUserFullName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNewUserAdress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNewUserCity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNewUserZipCode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void listBCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnRemoveCustomer.IsEnabled = (listBCustomers.SelectedItem != null);
        }

        private void btnSaveUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Customer newCustomer = new Customer(txtNewUserFullName.Text, txtNewUserAdress.Text, int.Parse(txtNewUserZipCode.Text), txtNewUserCity.Text, age, int.Parse(txtNewUserTelehone.Text), txtNewUserEmail.Text);
                customerList.Add(newCustomer);
                listBCustomers.Items.Refresh();
                //SaveCustomers(newCustomer);
                SaverAndLoader.ObjectToJsonString(customerList);
                ClearTextBoxes();
            }
            catch
            {
                MessageBox.Show("Alle input skal være korrekt format!");
            }
        }

        private void ClearTextBoxes()
        {
            txtNewUserAdress.Clear();
            txtNewUserCity.Clear();
            txtNewUserEmail.Clear();
            txtNewUserFullName.Clear();
            txtNewUserTelehone.Clear();
            txtNewUserZipCode.Clear();
        }

        private void btnExitNewUser_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnShowCustomerInfo_Click(object sender, RoutedEventArgs e)
        {
            Customer kunde = listBCustomers.SelectedItem as Customer;
            tabWindows.CustomerInfo dialog = new tabWindows.CustomerInfo(kunde);
            dialog.SetPerson();
            dialog.ParentWindow = this;
            dialog.Show();
        }

        private void btnRemoveCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = listBCustomers.SelectedItem as Customer;
            customerList.Remove(customer);
            listBCustomers.Items.Refresh();
        }

        private void btnOpretEvent_Click(object sender, RoutedEventArgs e)
        {
            CreateEventClass newEvent = new CreateEventClass(int.Parse(txtEventId.Text), txtEventNavn.Text, DateTime.Parse(txtEventDato.Text), int.Parse(txtEventMaxDeltagere.Text), double.Parse(txtEventPrisPerPerson.Text));
            eventRservationsListe.Add(newEvent);
            //SaveEventReservationToTxtFile();

        }

        private void btnCalenderShowEvents_Click(object sender, RoutedEventArgs e)
        {

         SaverAndLoader.LoadCustomer(customerList);

            //try
            //{
            //    using (StreamReader sr = new StreamReader("TEST.txt")) //Skal bare have den rigtige sti til Event og Reservationer
            //    {
            //        string line = sr.ReadToEnd(); //Declare line variable and sets ReadToEnd to it

            //        listBoxCalender.Items.Add(line);//Add our string "line" to listbox
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Can't Read Path");//Catch Exception if StreamReader Fails

            //}
            
        }

        private void btnCalenderShowReservation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("TEST.txt")) //Skal bare have den rigtige sti til Event og Reservationer
                {
                    string line = sr.ReadToEnd(); //Declare line variable and sets ReadToEnd to it

                    listBoxCalender.Items.Add(line);//Add our string "line" to listbox
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't Read Path");//Catch Exception if StreamReader Fails

            }
        }

        private void listBoxCalender_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

     

  
        //New User Controls Ends......
    }
}
