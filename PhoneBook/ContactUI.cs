using PhoneBook.Helpers;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class ContactUI
    {
        public static Contact GetContactFromUser() {
            var contact = new Contact();
            Console.WriteLine("Name:");
            contact.Name = Console.ReadLine();
            do {
                Console.WriteLine("Email:");
                contact.Email = Console.ReadLine();
            } 
            while (!ValidationHelpers.IsValidEmail(contact.Email));

            do {
                Console.WriteLine("Phone Number:");
                contact.PhoneNumber = Console.ReadLine();
            } 
            while (!ValidationHelpers.IsValidNumber(contact.PhoneNumber));

            return contact;
        }

        public static void ShowContacts(List<Contact> contacts) {
            foreach(var contact in contacts) {
                Console.WriteLine($"{contact.Id} | {contact.Name} | {contact.Email} | {contact.PhoneNumber}");
            }
        }

        public static int GetContactId() {
            Console.WriteLine("Contact ID: ");
            int id;
            while(!int.TryParse(Console.ReadLine(), out id)) {
                Console.WriteLine("Invalid ID, try again.");
            }

            return id;
        }

        public static void ShowEditMenu(Contact contact) {
            Console.WriteLine($"New Name: ");
            var newName = Console.ReadLine();
            if (!string.IsNullOrEmpty(newName)) {
                contact.Name = newName;
            }

            do {
                Console.WriteLine("New Email: ");
                var newEmail = Console.ReadLine();
                if (!string.IsNullOrEmpty(newEmail)) {
                    contact.Email = newEmail;
                }
            } while (!ValidationHelpers.IsValidEmail(contact.Email));

            do {
                Console.WriteLine("New Phone number: ");
                var newPhone = Console.ReadLine();
                if (!string.IsNullOrEmpty(newPhone)) {
                    contact.PhoneNumber = newPhone;
                }
            } while (!ValidationHelpers.IsValidNumber(contact.PhoneNumber));
        }

        public static bool ShowDeletionConfirmation(Contact contact) {
            Console.WriteLine($"{contact.Name} will be deleted. You sure? (Y/N)");
            string answer = Console.ReadLine().Trim().ToLower();
            return answer == "y";
        }
    }
}
