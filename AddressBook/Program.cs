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
            Console.WriteLine("\n1.Create Contact\n2.Add New Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //UC1 - Create Contact
                case 1:
                    AddressBook1.CreateContacts();
                    break;

                case 2:
                    Console.WriteLine("\n Add New Contact to Address Book");
                    AddressBook1.CreateContacts();
                    break;

                default:
                    Console.WriteLine("\nChoose from given option only!\n");
                    break;
            }
            Console.ReadLine();
        }
        
    }
}

