using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook1
    {
        public static void CreateContacts()
        {
            //reading data and storing in set method/properties 

            
            Contact contact = new Contact();
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name : ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            string address = Console.ReadLine();

            Console.Write("Enter City Name : ");
            string city = Console.ReadLine();

            Console.Write("Enter State Name : ");
            string state = Console.ReadLine();

            Console.Write("Enter ZIP Code : ");
            int ZIPCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Phone Number : ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Email Id : ");
            string email = Console.ReadLine();

            List<Contact> data = new List<Contact>();
            data.Add(contact); //Add is a method in List

            foreach (Contact record in data)
            {
                Console.WriteLine("First Name : " + record.FirstName);
                Console.WriteLine("Last Name : " + record.LastName);
                Console.WriteLine("Address : " + record.Address);
                Console.WriteLine("City : " + record.City);
                Console.WriteLine("State : " + record.State);
                Console.WriteLine("ZIP Code : " + record.ZIPCode);
                Console.WriteLine("Phone Number : " + record.PhoneNumber);
                Console.WriteLine("Email Id : " + record.Email);
            }
        }
        
    }
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZIPCode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
