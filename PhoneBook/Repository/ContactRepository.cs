using PhoneBook.Data;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Repository
{
    public class ContactRepository
    {
        private readonly PhoneBookContext _context;

        public ContactRepository(PhoneBookContext context) {
            _context = context;
        }

        public void AddContact(Contact contact) {
            _context.Add(contact);
            Console.WriteLine();
            _context.SaveChanges();
        }

        public List<Contact> GetAllContacts() => _context.contacts.ToList();
        
        public void UpdateContact(Contact contact) {
            _context.Update(contact);
            _context.SaveChanges();
        }

        public bool DeleteContact(int id) {
            var contact = _context.contacts.Find(id);
            if(contact != null) {
                _context.contacts.Remove(contact);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Contact? GetContactById(int id) => _context.contacts.Find(id);
    }
}
