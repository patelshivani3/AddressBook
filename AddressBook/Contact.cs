using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZIPCode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public static List<Contact> data = new List<Contact>();

        public Contact()         //Created Default Constructor
        {

        }
        public Contact(string FirstName, string LastName, string Address, string City, string State,int ZipCode ,long PhoneNumber, string EmailId)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZIPCode= ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = EmailId;
        }
        public static void CreateContacts(int num)
        {
            //reading data and storing in set method/properties 
            for(int i = 0; i < num; i++)
            {
                Contact contact = new Contact();
                Console.Write("Enter First Name : ");
                contact.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name : ");
                contact.LastName = Console.ReadLine();

                Console.Write("Enter Address : ");
                contact.Address = Console.ReadLine();

                Console.Write("Enter City Name : ");
                contact.City = Console.ReadLine();

                Console.Write("Enter State Name : ");
                contact.State = Console.ReadLine();

                Console.Write("Enter ZIP Code : ");
                contact.ZIPCode = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Phone Number : ");
                contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

                Console.Write("Enter Email Id : ");
                contact.Email = Console.ReadLine();

                data.Add(contact); //Add is a method in List
                Console.WriteLine("...............................................");
            }            
        }
        public  static void DisplayContact()
        {
            //CreateContacts();
            foreach (Contact record in data)
            {
                Console.WriteLine("\n===================================================");
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
        public static void EditContact()
        {
           
            Console.WriteLine("\nTo Edit Contact Enter The First Name:\n");
            string name = Console.ReadLine();
            foreach (var record in data)
            {
                if (record.FirstName == name)
                {
                    Console.WriteLine("\nContact Found...Enter the option to Edit the Contact: ");
                    Console.WriteLine("\n1.Edit First name\n2.Edit Last name\n3.Edit Address\n4.Edit City\n5.Edit State\n6.Edit Zip\n7.Edit Phonenumber\n8.Edit Email");
                    int option1 = Convert.ToInt32(Console.ReadLine());
                    switch (option1)
                    {
                        case 1:
                            Console.WriteLine("Enter the New First Name: ");
                            string newFirstName = Console.ReadLine();
                            record.FirstName = newFirstName;
                             break;
                        case 2:
                            Console.WriteLine("Enter the New Last Name: ");
                            string newLastName = Console.ReadLine();
                            record.LastName = newLastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter the New Address: ");
                            string newAddress = Console.ReadLine();
                            record.Address = newAddress;

                            break;
                        case 4:
                            Console.WriteLine("Enter the New City: ");
                            string newCity = Console.ReadLine();
                            record.City = newCity;
                            break;
                        case 5:
                            Console.WriteLine("Enter the New State: ");
                            string newState = Console.ReadLine();
                            record.State = newState;
                            break;
                        case 6:
                            Console.WriteLine("Enter the New Zip Code: ");
                            int newZIPCode = Convert.ToInt32(Console.ReadLine());
                            record.ZIPCode = newZIPCode;
                            break;
                        case 7:
                            Console.WriteLine("Enter the New Phone Number: ");
                            long newPhoneNumber = Convert.ToInt64(Console.ReadLine());
                            record.PhoneNumber = newPhoneNumber;
                            break;
                        case 8:
                            Console.WriteLine("Enter the New Email: ");
                            string newEmail = Console.ReadLine();
                            record.Email = newEmail;
                            break;
                        default:
                            Console.WriteLine("\nChoose from Given Options Only");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Contact Not Found...");
                }
            }
        }
        public static void deleteContact()      //Creating method for delete contact
        {
            bool flag = false;
            Console.WriteLine("\nTo Remove Contact Enter The First Name:\n");
            string name = Console.ReadLine();
            foreach (Contact record in data)
            {
                if (record.FirstName == name)
                {
                    flag = true;
                    data.Remove(record);
                    Console.WriteLine("The contact is successfully removed");
                    break;
                }
            }
            if (flag == false)
                Console.WriteLine("The contact is not found");
        }
    }
}
