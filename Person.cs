using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    internal class Person
    {
        private string name;
        private string email;
        private string phoneNumber;

        const string DEF_NAME = "N/A";
        const string DEF_EMAIL = "N/A";
        const string DEF_PHONE = "N/A";

        public string Name { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Person(): this(DEF_NAME, DEF_EMAIL, DEF_PHONE) { }

        public Person(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nEmail: " + Email + "\nPhone Number: " + PhoneNumber;
        }
    }
}
