using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddingOfMultiplePersonToAddressBook
    {
        Dictionary<string, string> Contacts;
        Dictionary<string, Dictionary<string, string>> addressBook = new Dictionary<string, Dictionary<string, string>>();
        public void PersonDetails()
        {
            Console.Write("First Name : ");
            Contacts.Add("First Name ", Console.ReadLine());

            Console.Write("Last Name : ");
            Contacts.Add("Last Name ", Console.ReadLine());

            Console.Write("Address : ");
            Contacts.Add("Address ", Console.ReadLine());

            Console.Write("City : ");
            Contacts.Add("City ", Console.ReadLine());

            Console.Write("State : ");
            Contacts.Add("State ", Console.ReadLine());

            Console.Write("Zip Code : ");
            Contacts.Add("Zip Code ", Console.ReadLine());

            Console.Write("Phone Number : ");
            Contacts.Add("Phone Number  ", Console.ReadLine());

            Console.Write("Email Address : ");
            Contacts.Add("Email Address ", Console.ReadLine());
        }
        
        public void ViewContact()
        {
            Console.WriteLine("Enter full name:");
            string contactName = Console.ReadLine();
            if (addressBook.ContainsKey(contactName))
            {
                Contacts = new Dictionary<string, string>();
                addressBook.TryGetValue(contactName, out Contacts);
                Console.WriteLine("First Name: " + Contacts["first Name"]);

                Console.WriteLine("Last Name:" + Contacts["last Name"]);

                Console.WriteLine("Address:" + Contacts["Address"]);

                Console.WriteLine("City:" + Contacts["City"]);

                Console.WriteLine("State:" + Contacts["State"]);

                Console.WriteLine("Zip:" + Contacts["Zip"]);

                Console.WriteLine("Phone number:" + Contacts["Phone number"]);

                Console.WriteLine("Email:" + Contacts["Email"]);
            }
            else
                Console.WriteLine("Contact doesn't exist");

        }
        
        public void EditContact()
        {
           
            Console.WriteLine("Enter full contact name");
            String contactName = Console.ReadLine();

            if (addressBook.ContainsKey(contactName))
            {
                Console.Write("Select option you want to edit : ");
                Console.WriteLine("1. First Name 2. Last Name 3. Address\n 4. City 5. State 6. Zip\n 7. Phone number  8. Email");

                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter contact field:");
                String Cotanctinfo = Console.ReadLine();

                switch (option)
                {
                    case 1:
                        addressBook[contactName]["First Name"] = Cotanctinfo;
                        break;
                    case 2:
                        addressBook[contactName]["Last Name"] = Cotanctinfo;
                        break;
                    case 3:
                        addressBook[contactName]["Address"] = Cotanctinfo;
                        break;
                    case 4:
                        addressBook[contactName]["City"] = Cotanctinfo;
                        break;
                    case 5:
                        addressBook[contactName]["State"] = Cotanctinfo;
                        break;
                    case 6:
                        addressBook[contactName]["Zip"] = Cotanctinfo;
                        break;
                    case 7:
                        addressBook[contactName]["Phone number"] = Cotanctinfo;
                        break;
                    case 8:
                        addressBook[contactName]["Email"] = Cotanctinfo;
                        break;

                }
            }
            else
            {
                Console.WriteLine("contact doesn't exist");
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter contact name:");
            String ContactName = Console.ReadLine();
            if (addressBook.ContainsKey(ContactName))
            {
                addressBook.Remove(ContactName);
                Console.WriteLine("contact removed");
            }
            else
                Console.WriteLine("contact doesn't exist");
        }
        public void Display()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }

}

