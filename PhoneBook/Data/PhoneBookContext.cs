using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook.Data
{
    public class PhoneBookContext : DbContext
    {
        public DbSet<Contact> contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PhoneBookDB;Trusted_Connection=True");
        }
    }
}
