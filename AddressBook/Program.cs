using AddressBook;
using System;

//Adding of PersonDetails
//CreatingContacts contacts = new CreatingContacts();
//AddingContacts Add = new AddingContacts();
//Add.PersonDetails();
//Add.Display();
//Displaying of contact details
//CreatingContacts contacts = new CreatingContacts();
//ContactEditing editing = new ContactEditing();
//editing.PersonDetails();
//editing.Display();
//editing.Edit();

//AddingOfMultipleCompany

//AddingOfMultiplePersonToAddressBook multiplecompany=new AddingOfMultiplePersonToAddressBook();
//multiplecompany.PersonDetails();
//multiplecompany.ViewContact();
//multiplecompany.EditContact();
//multiplecompany.DeleteContact();
//multiplecompany.Display();

//Refactor Code of MultipleCompany

//RefactorToAddMultipleAddressBook addressBook= new RefactorToAddMultipleAddressBook();
//addressBook.PersonDetails();
//addressBook.display();
//addressBook.EditContact();
//addressBook.DeleteContact();
//addressBook.CreateAddressBook();
//addressBook.ChangeAddressBook();

//Checking Of an DuplicateEnrty in Addressbook
//CheckingOfDuplicateEntry CheckingOfDuplicate=new CheckingOfDuplicateEntry();
//CheckingOfDuplicate.PersonDetails();
//CheckingOfDuplicate.AddContact();
//CheckingOfDuplicate.ViewContact();
//CheckingOfDuplicate.EditContact();
//CheckingOfDuplicate.DeleteContact();
//CheckingOfDuplicate.CreateAddressBook();
//CheckingOfDuplicate.ChangeAddressBook();
//CheckingOfDuplicate.Display();
//CheckingOfDuplicate.EditContact();
//CheckingOfDuplicate.DeleteContact();
//CheckingOfDuplicate.CreateAddressBook();
//CheckingOfDuplicate.Display();

//Ability to search person in city or state across the multiple Address Book
EngineerDetails engineer=new EngineerDetails();
engineer.ToString();
MultipleAddressBook addressbook=new MultipleAddressBook();
addressbook.ContactList();
addressbook.Count();
addressbook.ComputeDetails();
addressbook.AddDetails("Engineer", "Sartaj", "Khan", "Whitefield", "Nagpur", "Maharashtra", 4400002, 9424777313, "sartajikhan786@gmail.com");
addressbook.AddDetails("Engineer", "Abhishek", "Jadhav", "Bandra", "Mumbai", "Maharashtra", 560464, 1236547899, "sartajikhan786@gmail.com");
addressbook.AddDetails("Engineer", "Shivraj", "Gawda", "Malleshwaram", "Bengaluru", "karnataka", 560066, 9424464313, "sartajikhan786@gmail.com");
addressbook.AddDetails("Engineer", "Rajesh", "Singh", "GTNagar", "pune", "Maharashtra", 564566, 9433777313, "sartajikhan786@gmail.com");
addressbook.AddDetails("Engineer", "Vivek", "Singh", "HSR", "Bengaluru", "karnataka", 560996, 9424777315, "sartajikhan786@gmail.com");
addressbook.AddDetails("Engineer", "Siddhant", "Singh", "City Centre", "Noida", "U.P.", 458963, 9425477313, "sartajikhan786@gmail.com");
Console.WriteLine("Enter Engineer Address Book Name : ");
string addressBook = Console.ReadLine();
addressbook.AddressBook(addressBook);
addressbook.ComputeDetails();
addressbook.Search();
addressbook.Count();
