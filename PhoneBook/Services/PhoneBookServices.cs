using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook;
using PhoneBook.Data;
using PhoneBook.Repository;
using PhoneBook.Helpers;

namespace PhoneBook.Services
{
    public class PhoneBookServices {
        private readonly ContactRepository _repository;

        public PhoneBookServices(ContactRepository repository) {
            _repository = repository;
        }

        public void AddContactWithValidation(Contact contact) {
            if (!ValidationHelpers.IsValidEmail(contact.Email))
                throw new ArgumentException("Invalid email");
            if (!ValidationHelpers.IsValidNumber(contact.PhoneNumber))
                throw new ArgumentException("Invalid Cellphone");

            _repository.AddContact(contact);
        }

        public List<Contact> GetAllContacts() {
            return _repository.GetAllContacts();
        }

        public bool UpdateContact(int id, Action<Contact> updateAction) {
            var contact = _repository.GetContactById(id);
            if (contact == null)
                Console.WriteLine("Contact does not exist.");
            return false;

            updateAction(contact);

            if (!ValidationHelpers.IsValidEmail(contact.Email))
                throw new ArgumentException("Invalid email");
            if (!ValidationHelpers.IsValidNumber(contact.PhoneNumber))
                throw new ArgumentException("Invalid Cellphone");

            _repository.UpdateContact(contact);
            return true;
        }

        public bool DeleteContact(int id) => _repository.DeleteContact(id);

        public Contact GetContactById(int id) => _repository.GetContactById(id);
    }
}
