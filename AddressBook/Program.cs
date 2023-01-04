using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome To Address Book Program");
            Console.WriteLine("\n1.Create Contact\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //UC1 - Create Contact
                case 1:
                    CreateContacts();
                    break;
                default:
                    Console.WriteLine("\nChoose from given option only!\n");
                    break;
            }
            Console.ReadLine();
        }
        public static void CreateContacts()
        {
            //reading data and storing in set method/properties 
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
        }
    }
}

