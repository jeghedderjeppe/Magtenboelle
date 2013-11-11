using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Oprettelse_Tilmelding
{
    public class CreateEventClass
    {
        //constructor
        public CreateEventClass(int id, string eventName, int date, int numberOfParticipant, double pricePrPerson)
        {
            Id = id;
            Name = eventName;
            Date = date;
            NumberOfParticipant = numberOfParticipant;
            PricePrPerson = pricePrPerson;
        }
        
        //backend fields
        int _id;
        string _name;
        DateTime _date;
        int _numberOfParticipant;
        double _pricePrPerson;

        //property with backend fields
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public int NumberOfParticipant
        {
            get { return _numberOfParticipant; }
            set { _numberOfParticipant = value; }
        }
        public double PricePrPerson
        {
            get { return _pricePrPerson; }
            set { _pricePrPerson = value; }
        }
    }
}
