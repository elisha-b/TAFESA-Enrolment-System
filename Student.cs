using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    class Student : Person
    {
        private string studentID;
        private string program;
        private string dateRegistered;
        private Enrolment enrolment;
        public const string DEF_STUDENT_ID = "N/A";
        public const string DEF_PROGRAM = "N/A";
        public const string DEF_DATE_REGISTERED = "N/A";

        public string StudentID { get; set; }

        public string Program { get; set; }

        public string DateRegistered { get; set; }

        public Enrolment Enrolment { get; set; }

        public Student() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE, new Address(), DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED, new Enrolment()) { }

        public Student(string name, string email, string phoneNumber, Address address,
            string studentID, string program, string dateRegistered, Enrolment enrolment)
            : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            Enrolment = enrolment;
        }

        public override string ToString()
        {
            return base.ToString() + "\nStudent ID: " + StudentID + "\nProgram: " + Program + "\nDate Registered: " + DateRegistered + "\n" + Enrolment;
        }

        /// <summary>
        /// Checks if two Student objects are == based on Student ID
        /// </summary>
        /// <param name="other">StudentID compared to current StudentID</param>
        /// <returns>True or False</returns>
        public bool Equals(Student other)
        {
            return StudentID == other.StudentID;
        }

        /// <summary>
        /// Checks if specified object == this object based on Student ID
        /// </summary>
        /// <param name="obj">Student object compared to current Student object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Student))
                return false;
            return StudentID.Equals(((Student)obj).StudentID);
        }

        /// <summary>
        /// Gets hash code for Student object based on Student ID
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }

        /// <summary>
        /// Checks if two Student objects are == based on Student ID
        /// </summary>
        /// <param name="x">First Student object</param>
        /// <param name="y">Second Student object</param>
        /// <returns>True or False</returns>
        public static bool operator ==(Student x, Student y)
        {
            return object.Equals(x, y);
        }

        /// <summary>
        /// Checks if two Student objects are != based on Student ID
        /// </summary>
        /// <param name="x">First Student object</param>
        /// <param name="y">Second Student object</param>
        /// <returns>True or False</returns>
        public static bool operator !=(Student x, Student y)
        {
            return !object.Equals(x, y);
        }
    }
}
