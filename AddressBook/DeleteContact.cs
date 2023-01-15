using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class DeleteContact
    {
        public class ContactEditing
        {
            public CreatingContacts contacts = new CreatingContacts();
            public List<CreatingContacts> addressbook = new List<CreatingContacts>();


            public void PersonDetails()
            {


                Console.WriteLine("Enter your FirstName :");
                contacts.firstName = Console.ReadLine();

                Console.WriteLine("Enter your LastName :");
                contacts.lastName = Console.ReadLine();

                Console.WriteLine("Enter your PhoneNumber :");
                contacts.phoneNumber = Convert.ToInt32(Console.ReadLine());

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

                CreatingContacts creatingContacts = new CreatingContacts();

                addressbook.Add(contacts);

            }
            public void Display()
            {
                Console.WriteLine(" firstName :" + contacts.firstName + " lastName :" + contacts.lastName + " phoneNumber :" + contacts.phoneNumber + "\n" +
                                    " Email-Id :" + contacts.email + " Address :" + contacts.address + " City :" + contacts.city + " State :" + contacts.state + "\n" +
                                    " ZipCode" + contacts.zipcode);
            }

            public void Edit()
            {
                Console.WriteLine("Enter your option in order to edit");
                Console.WriteLine("1.firstname,2.lastname,3.email,4.phonenumber,5.city,6.state,7.zipcode");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        Console.WriteLine("Enter your firstname need to change: ");
                        string newname = Console.ReadLine();
                        contacts.firstName = newname;
                        Console.WriteLine("firstname is :" + contacts.firstName);
                        break;

                    case 2:

                        Console.WriteLine("Enter your lastname need to change: ");
                        string Newname = Console.ReadLine();
                        contacts.lastName = Newname;
                        Console.WriteLine("lastname is :" + contacts.lastName);
                        break;

                    case 3:

                        Console.WriteLine("Enter your email id need to change: ");
                        string email = Console.ReadLine();
                        contacts.email = email;
                        Console.WriteLine("your email id :" + contacts.email);
                        break;

                    case 4:

                        Console.WriteLine("Enter your phonenumber: ");
                        int phonenumber = Convert.ToInt32(Console.ReadLine());
                        contacts.phoneNumber = phonenumber;
                        break;

                    case 5:

                        Console.WriteLine("Enter your Address: ");
                        string address = Console.ReadLine();
                        contacts.address = address;
                        break;

                    case 6:

                        Console.WriteLine("Enter your city: ");
                        string city = Console.ReadLine();
                        contacts.city = city;
                        break;

                    case 7:

                        Console.WriteLine("Enter your state: ");
                        string state = Console.ReadLine();
                        contacts.state = state;
                        break;

                    case 8:

                        Console.WriteLine("Enter your Zipcode: ");
                        int zipcode = Convert.ToInt32(Console.ReadLine());
                        contacts.zipcode = zipcode;
                        break;

                    default:
                        Console.WriteLine("I'ts Invalid");
                        break;
                }
            }
            public void Delete()
            {
                CreatingContacts delete = new CreatingContacts();
                Console.WriteLine("Enter your firstname: ");
                string name=Console.ReadLine();
                foreach(var contacts in addressbook)
                {
                    if (name == contacts.firstName)
                    {
                         delete = contacts;

                    }
                }

                addressbook.Remove(delete);
                Display();
            }







            }
        }
    }
}
