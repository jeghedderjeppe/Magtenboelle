using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tabWindows {
	class SaverAndLoader {
		public static void LoadCustomer() {
			List<Customer> customer = JsonStringToObject(ReadFromFile("customer-json.txt"));
		}

		public static void SaveCustomer(List<Customer> customer) {
			ObjectToJsonString(customer);
		}


		private static String ReadFromFile(string fileName) {
			string fileString;
			StreamReader textFile;
			textFile = File.OpenText(fileName);
			fileString = textFile.ReadToEnd();
			textFile.Close();
			return fileString;
		}

		private static void WriteToFile(string text, string fileName) {
			using(StreamWriter file = new StreamWriter(fileName, false)) {
				file.Write(text);
				file.Close();
			}
		}

		public static void ObjectToJsonString(List<Customer> listObject) {
			string source = JsonConvert.SerializeObject(listObject);
			//Console.WriteLine(source);
			WriteToFile(source, @"customer-json.txt");
		}

		private static List<Customer> JsonStringToObject(String jsonString) {
			List<Customer> customer = JsonConvert.DeserializeObject<List<Customer>>(jsonString);
			/*foreach(UserData user in users) {
				userLib[user.idNumber] = user;
			}*/
			return customer;
		}
	}
}
