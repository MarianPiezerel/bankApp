using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public static class Session
    {
        public static int UserId { get; set; }
        public static string EmailAddress { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
    }
}
