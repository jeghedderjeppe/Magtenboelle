using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTBClass
{
    class MTB_ReservationsKlasse
    {   //3 variabler, som har en property hver.
        int _age;
        double _weight;
        bool _memberOfCycleUnion;

        //En constructor til de kunder, som gerne vil bestille tis på MTB-banen(uden at leje cykler)
        public MTB_ReservationsKlasse(int age, bool memberOfCycleUnion)
        {
            Age = age;
            MemberOfCycleUnion = memberOfCycleUnion;
        }

        //En constructor til de kunder, som gerne vil bestille tid på MTB-banen og leje cykler
        public MTB_ReservationsKlasse(int age, double weight, bool memberOfCycleUnion)
        {
            Age = age;
            Weight = weight;
            MemberOfCycleUnion = memberOfCycleUnion;
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
    }
}
