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
using System.Windows.Shapes;

namespace tabWindows
{
    /// <summary>
    /// Interaction logic for CustomerInfo.xaml
    /// </summary>
    public partial class CustomerInfo : Window
    {
         Customer customer;
         public CustomerInfo(Customer customerb)
         {
            InitializeComponent();
            customer = customerb;
         }
          public void SetPerson()
          {
            txtEditUserFullName.Text = customer.Name;
            txtEditUserPhoneNum.Text = customer.PhoneNum.ToString();
            txtEditUserEmail.Text = customer.Email;              
            txtEditUserAddress.Text = customer.Adress.StreetName;
            txtEditUserCity.Text = customer.Adress.City;
            txtEditUserZipCode.Text = customer.Adress.PostCode.ToString();
            txtEditUserAge.Text = customer.Age.ToString();
          }
          private void btnSaveEditedUserInfo_Click(object sender, RoutedEventArgs e)
          {
              try
              {
                  customer.Name = txtEditUserFullName.Text;
                  customer.PhoneNum = int.Parse(txtEditUserPhoneNum.Text);
                  customer.Email = txtEditUserEmail.Text;
                  customer.Adress.StreetName = txtEditUserAddress.Text;
                  customer.Adress.City = txtEditUserCity.Text;
                  customer.Adress.PostCode = int.Parse(txtEditUserZipCode.Text);
                  customer.Age = byte.Parse(txtEditUserAge.Text);
                  ParentWindow.listBCustomers.Items.Refresh();
                  this.Close();
              }
              catch
              {
                  MessageBox.Show("Alle input skal være korrekt format!");
              }
          }
        
        public MainWindow ParentWindow { get; set; }
        public  Customer customers { get; set; }
        
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}


    
