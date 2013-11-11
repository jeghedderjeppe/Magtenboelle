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
        public EventRegistrationClass(string firstName, string lastName, int numberOfParticipant, double pricePrPerson, string suggestion)
        {
            FirstName = firstName;
            LastName = lastName;
            NumberOfParticipant = numberOfParticipant;
            PricePrPerson = pricePrPerson;
            Suggestion = suggestion;
        }
        
        //backend fields
        
        int _numberOfParticipant;
        double _pricePrPerson;
        string _suggestion;
        DateTime _date;
        string _firstName;
        string _lastName;

        //property with backend fields
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
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
