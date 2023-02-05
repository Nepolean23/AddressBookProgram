using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CheckingOfDuplicateEntry
    {
        Dictionary<String, String> contacts;
        Dictionary<String, Dictionary<String, String>> addressBook = new Dictionary<String, Dictionary<String, String>>();
        Dictionary<String, Dictionary<String, Dictionary<String, String>>> AddressBookCollection = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
        String CurrentAddressBookName = "default";

        public void PersonDetails()
        {

            Console.Write("Enter your FirstName :");
            contacts.Add("FirstName", Console.ReadLine());

            Console.Write("Enter your LastName :");
            contacts.Add("LastName", Console.ReadLine());

            Console.Write("Enter your PhoneNumber :");
            contacts.Add("PhoneNumber", Console.ReadLine());

            Console.Write("Enter your Email-Id :");
            contacts.Add("Email-Id", Console.ReadLine());

            Console.Write("Enter your Address :");
            contacts.Add("Address", Console.ReadLine());

            Console.Write("Enter your City :");
            contacts.Add("City", Console.ReadLine());

            Console.Write("Enter your State :");
            contacts.Add("State", Console.ReadLine();

            Console.Write("Enter your ZipCode :");
            contacts.Add("Zipcode", Console.ReadLine());
        }
        public void AddContact()
        {
            Console.Write("Add contact");
            contacts = new Dictionary<string, string>();

            Console.Write("First Name : ");
            contacts.Add("First Name ", Console.ReadLine());

            Console.Write("Last Name : ");
            contacts.Add("Last Name ", Console.ReadLine());

            Console.Write("Address : ");
            contacts.Add("Address ", Console.ReadLine());

            Console.Write("City : ");
            contacts.Add("City ", Console.ReadLine());

            Console.Write("State : ");
            contacts.Add("State ", Console.ReadLine());

            Console.Write("Zip Code : ");
            contacts.Add("Zip Code ", Console.ReadLine());

            Console.Write("Phone Number : ");
            contacts.Add("Phone Number  ", Console.ReadLine());

            Console.Write("Email Address : ");
            contacts.Add("Email Address ", Console.ReadLine());

            contacts.TryGetValue("First Name", out string FirstName);
            contacts.TryGetValue("Last Name", out string LastName);
            addressBook.Add(FirstName + " " + LastName, contacts);
            Console.WriteLine("Contact added\n");

        }
        public void ViewContact()
        {
            Console.WriteLine("Enter full name:");
            string contactName = Console.ReadLine();
            if (addressBook.ContainsKey(contactName))
            {
                contacts = new Dictionary<string, string>();
                addressBook.TryGetValue(contactName, out contacts);
                Console.WriteLine("First Name: " + contacts["First Name"]);

                Console.WriteLine("Last Name:" + contacts["Last Name"]);

                Console.WriteLine("Address:" + contacts["Address"]);

                Console.WriteLine("City:" + contacts["City"]);

                Console.WriteLine("State:" + contacts["State"]);

                Console.WriteLine("Zip:" + contacts["Zip"]);

                Console.WriteLine("Phone number:" + contacts["Phone number"]);

                Console.WriteLine("Email:" + contacts["Email"]);
            }
            else
                Console.WriteLine("Contact doesn't exist");
        }

        public void EditContact()
        {
            //Edit information
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
            //Delete contact
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

        public void CreateAddressBook()
        {
            addressBook = new Dictionary<string, Dictionary<string, string>>();
            Console.WriteLine("Address Book Name: ");
            string addressBookName = Console.ReadLine();
            if (AddressBookCollection.ContainsKey(addressBookName))
                Console.WriteLine("Address Book already exist");
            else
            {
                AddressBookCollection.Add(addressBookName, addressBook);
                CurrentAddressBookName = addressBookName;
                Console.WriteLine("Address Book created");
            }
        }

        public void ChangeAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string addressBookName = Console.ReadLine();
            if (AddressBookCollection.ContainsKey(addressBookName))
            {
                CurrentAddressBookName = addressBookName;
                Console.WriteLine("Address Book changed");
            }
            else
                Console.WriteLine("Address Book doesn't exist");
        }

        public void Display()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }        
}
