using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabWindows {
	public class Customer {
		private int _id;
		private string _name;
		public Address Adress;
		private byte _age;
		private int _phoneNum;
		private string email;
		private static int autoIncrementId = 0;

		public int Id {
			get { return _id; }
			set { _id = value; }
		}
		
		public string Name {
			get { return _name; }
			set { _name = value; }
		}
		
		public byte Age {
			get { return _age; }
			set { _age = value; }
		}

		public int PhoneNum {
			get { return _phoneNum; }
			set { _phoneNum = value; }
		}

		public string Email {
			get { return email; }
			set { email = value; }
		}

		public Customer(string name, string streetName, int postCode, string city, byte age, int phoneNum, string email) {
			Id = autoIncrementId;
			Name = name;
			Adress = new Address(streetName, postCode, city);
			Age = age;
			PhoneNum = phoneNum;
            Email = email;
			autoIncrementId++;
		}

		public Customer(string name, string streetName, int postCode, string city, string country, byte age, int phoneNum) {
			Id = autoIncrementId;
			Name = name;
			Adress = new Address(streetName, postCode, city, country);
			Age = age;
			PhoneNum = phoneNum;
			autoIncrementId++;
		}
        public override string ToString()
        {
            return Name + " | " + Email;
        }
	}

	public class Address {
		private string _streetName;
		private int _postCode;
		private string _city;
		private string _country;

		public string StreetName {
			get { return _streetName; }
			set { _streetName = value; }
		}

		public int PostCode {
			get { return _postCode; }
			set { _postCode = value; }
		}

		public string City {
			get { return _city; }
			set { _city = value; }
		}

		public string Country {
			get { return _country; }
			set { _country = value; }
		}

		public Address(string streetName, int postCode, string city) {
			StreetName = streetName;
			PostCode = postCode;
			City = city;
		}

		public Address(string streetName, int postCode, string city, string country) {
			StreetName = streetName;
			PostCode = postCode;
			City = city;
			Country = country;
		}

	}
}
