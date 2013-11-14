using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabWindows;

namespace MTBClass 
{
    class MTB_ReservationsKlasse : IResAndEvents
    {   //3 variabler, som har en property hver.
        int _age;
        double _weight;
        bool _memberOfCycleUnion;
        DateTime _date;
        string _firstName;
        string _lastName;
      
       

      
        //En constructor til de kunder, som gerne vil bestille tis på MTB-banen(uden at leje cykler)
        public MTB_ReservationsKlasse(string firstName, string lastName, DateTime date, int age, bool memberOfCycleUnion)
        {
            Age = age;
            MemberOfCycleUnion = memberOfCycleUnion;
            Date = date;
            FirstName = firstName;
            LastName = lastName;

        }

        //En constructor til de kunder, som gerne vil bestille tid på MTB-banen og leje cykler
        public MTB_ReservationsKlasse(DateTime date, int age, double weight, bool memberOfCycleUnion)
        {
            Age = age;
            Weight = weight;
            MemberOfCycleUnion = memberOfCycleUnion;
            Date = date;
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public bool MemberOfCycleUnion
        {
            get { return _memberOfCycleUnion; }
            set { _memberOfCycleUnion = value; }
        }
        
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
      
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
    }
}
