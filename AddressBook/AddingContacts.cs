using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddingContacts
    {
        CreatingContacts contacts = new CreatingContacts();
        public  void PersonDetails()
        {
           
            Console.WriteLine("Enter your FirstName :");
            contacts.firstName = Console.ReadLine();

            Console.WriteLine("Enter your LastName :");
            contacts.lastName = Console.ReadLine();

            Console.WriteLine("Enter your PhoneNumber :");
            contacts.phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter your Email-Id :");
            contacts.email = Console.ReadLine();

            Console.WriteLine("Enter your Address :");
            contacts.address = Console.ReadLine();

            Console.WriteLine("Enter your City :");
            contacts.city = Console.ReadLine();

            Console.WriteLine("Enter your Sate :");
            contacts.state = Console.ReadLine();

            Console.WriteLine("Enter your ZipCode :");
            contacts.zipcode = Convert.ToInt32(Console.ReadLine());

            

            
        }
    }
}
