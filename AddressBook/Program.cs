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
            Console.WriteLine("\n1.Create Contact\n2.Add New Contact\n3.Edit Contact\n4.Delete Contact\n5.Add Multiple Contact\n6.Add Multiple Address Book");
            Contact contact = new Contact();
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the Number Of Contact You Want To Add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //UC1 - Create Contact
                case 1:
                    Contact.CreateContacts(num);
                    Contact.DisplayContact();
                    break;

                case 2:
                    Console.WriteLine("\nAdd New Contact to Address Book");
                    Contact.CreateContacts(num);
                    Contact.DisplayContact();
                    break;

                case 4:
                    Console.WriteLine("\nEdit The Contact From Address Book");
                    Contact.CreateContacts(num);
                    Contact.DisplayContact();
                    Contact.deleteContact();
                    Contact.DisplayContact();
                    break;
                case 5:
                    
                    Contact.CreateContacts(num);
                    Contact.DisplayContact();
                    break;
                case 6:
                    Contact.AddressBook();
                    break;

                default:
                    Console.WriteLine("\nChoose from given option only!\n");
                    break;
            }
            Console.ReadLine();
        }
        
    }
}

