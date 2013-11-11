using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class BedAndBreakFastClass
    {
        //Constructor 
        public BedAndBreakFastClass(DateTime date, string firstname, string lastname, string pets, string customersplans )
        {
             Firstname = firstname;
             Lastname = lastname;
             Pets = pets;
             Customersplans = customersplans;
             Date = date;
        }

        //Backend Fields
        string _firstname;
        string _lastname;
        string _pets;
        string customersplans;
        DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Customersplans
        {
            get { return customersplans; }
            set { customersplans = value; }
        }

        public string Pets
        {
            get { return _pets; }
            set { _pets = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
    }
}
