using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneBook.Helpers
{
    public static class ValidationHelpers {
        public static bool IsValidEmail(string email) {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch {
                return false;
            }
        }

        public static bool IsValidNumber(string phone) {
            try {
                var regex = new Regex(@"^\+(?:[0-9]●?){6,14}[0-9]$");
                return regex.IsMatch(phone);
            }
            catch {
                return false;
            }
            
        }
    }
}
