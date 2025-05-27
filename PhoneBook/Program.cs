using PhoneBook.Data;
using PhoneBook.Repository;
using PhoneBook.Services;

namespace PhoneBook {
    internal class Program {
        static void Main(string[] args) {
            var context = new PhoneBookContext();
            var repository = new ContactRepository(context);
            var service = new PhoneBookServices(repository);

            bool runProgram = true;
            while (runProgram) {
                ShowMenu();
                var option = Console.ReadLine();
                switch (option) {
                    case "1":
                        var contact = ContactUI.GetContactFromUser();
                        service.AddContactWithValidation(contact);
                        break;
                    case "2":
                        var contacts = service.GetAllContacts();
                        ContactUI.ShowContacts(contacts);
                        break;
                    case "3":
                        var editId = ContactUI.GetContactId();
                        var contactToEdit = service.GetContactById(editId);

                        if(contactToEdit != null) {
                            ContactUI.ShowEditMenu(contactToEdit);
                            service.UpdateContact(editId, c => {
                                c.Name = contactToEdit.Name;
                                c.Email = contactToEdit.Email;
                                c.PhoneNumber = contactToEdit.PhoneNumber;
                            });
                            Console.WriteLine("Updated contact.");
                        }
                        else {
                            Console.WriteLine("Contact not found.");
                        }
                        break;
                    case "4":
                        var deleteId = ContactUI.GetContactId();
                        var contactToDelete = service.GetContactById(deleteId);
                        if (contactToDelete != null & ContactUI.ShowDeletionConfirmation(contactToDelete)) {
                            if (service.DeleteContact(deleteId)) {
                                Console.WriteLine("Contact deleted.");
                            }
                            else {
                                Console.WriteLine("Failed to delete contact.");
                            }
                        }
                        else {
                            Console.WriteLine("Contact not found.");
                        }
                        break;
                    case "5":
                        runProgram = false;
                        break;
                }

            }
          }
         private static void ShowMenu() {
            Console.WriteLine("------PHONE BOOK------");
            Console.WriteLine("1 - ADD CONTACT");
            Console.WriteLine("2 - LIST CONTACTS");
            Console.WriteLine("3 - UPDATE CONTACTS");
            Console.WriteLine("4 - REMOVE CONTACTS");
            Console.WriteLine("5 - CLOSE APP");
        }
        }
    }
