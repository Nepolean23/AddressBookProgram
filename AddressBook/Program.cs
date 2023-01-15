using AddressBook;
using System;

//Adding of PersonDetails
//CreatingContacts contacts = new CreatingContacts();
//AddingContacts Add = new AddingContacts();
//Add.PersonDetails();
//Add.Display();
//Displaying of contact details
CreatingContacts contacts = new CreatingContacts();
ContactEditing editing = new ContactEditing();
editing.PersonDetails();
editing.Display();
editing.Edit();