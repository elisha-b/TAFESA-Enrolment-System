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
        private Address address;

        public const string DEF_NAME = "N/A";
        public const string DEF_EMAIL = "N/A";
        public const string DEF_PHONE = "N/A";

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Address Address { get; set; }

        public Person(): this(DEF_NAME, DEF_EMAIL, DEF_PHONE, new Address()) { }

        public Person(string name, string email, string phoneNumber, Address address) : base()
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public override string ToString()
        {
            return base.ToString() + "\nName: " + Name + "\nEmail: " + Email + "\nPhone Number: " + PhoneNumber + "\nAddress: " + Address; 
        }
    }
}
