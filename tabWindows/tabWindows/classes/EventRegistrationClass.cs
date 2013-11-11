using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Oprettelse_Tilmelding
{
    
    public class EventRegistrationClass
    {
        //constructor
        public EventRegistrationClass(string name, int numberOfParticipant, double pricePrPerson, string suggestion)
        {
            Name = name;
            NumberOfParticipant = numberOfParticipant;
            PricePrPerson = pricePrPerson;
            Suggestion = suggestion;
        }
        
        //backend fields
        string _name;
        int _numberOfParticipant;
        double _pricePrPerson;
        string _suggestion;
        DateTime _date;

        //property with backend fields
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        public string Suggestion
        {
            get { return _suggestion; }
            set { _suggestion = value; }
        }
    }
}
