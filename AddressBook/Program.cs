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
            Console.WriteLine("\nWelcome to Address Book Programs");
           //UC1 Create a contact deatails of person
            Person.AddPerson();
            Person.PrintPerson();
            Console.ReadLine();
        }
    }
}
