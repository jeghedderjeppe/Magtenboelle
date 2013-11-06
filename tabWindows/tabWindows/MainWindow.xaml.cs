﻿using System;
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

namespace tabWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customerList = new List<Customer>();
        byte age = 0;
        public MainWindow()
        {
            InitializeComponent();
            
            Customer lars = new Customer("lars", "Odensevej 17", 5000, "Odense", 23, 47583928, "lars@gmail.com");
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
        //New User Controls Ends......
    }
}