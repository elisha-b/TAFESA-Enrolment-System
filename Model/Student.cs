using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System.Model
{
    internal class Student : Person, IComparable<Student>
    {
        public const string DEF_STUDENT_ID = "N/A";
        public const string DEF_PROGRAM = "N/A";
        public const string DEF_DATE_REGISTERED = "N/A";

        public string StudentID { get; set; }

        public string Program { get; set; }

        public string DateRegistered { get; set; }

        public Enrolment Enrolment { get; set; }

        // No-arg constructor
        public Student() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE, new Address(), DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED, new Enrolment()) { }

        // Single-arg constructor (StudentID)
        public Student(string studentID) : this(DEF_NAME, DEF_EMAIL, DEF_PHONE, new Address(), studentID, DEF_PROGRAM, DEF_DATE_REGISTERED, new Enrolment()) { }

        // All-arg constructor
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
            return Equals(x, y);
        }

        /// <summary>
        /// Checks if two Student objects are != based on Student ID
        /// </summary>
        /// <param name="x">First Student object</param>
        /// <param name="y">Second Student object</param>
        /// <returns>True or False</returns>
        public static bool operator !=(Student x, Student y)
        {
            return !Equals(x, y);
        }

        /// <summary>
        /// Checks if which of two Student objects are `<` based on Student ID
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>True or False</returns>
        public static bool operator <(Student x, Student y)
        {
            if (ReferenceEquals(x, null))
                return false;

            return x.StudentID.CompareTo(y.StudentID) < 0;
        }

        /// <summary>
        /// Checks if which of two Student objects are `<=` based on Student ID
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>True or False</returns>
        public static bool operator <=(Student x, Student y)
        {
            if (ReferenceEquals(x, null))
                return false;

            return x.StudentID.CompareTo(y.StudentID) <= 0;
        }

        /// <summary>
        /// Checks if which of two Student objects are `>` based on Student ID
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>True or False</returns>
        public static bool operator >(Student x, Student y)
        {
            if (ReferenceEquals(x, null))
                return false;

            return x.StudentID.CompareTo(y.StudentID) > 0;
        }

        /// <summary>
        /// Checks if which of two Student objects are `>=` based on Student ID
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>True or False</returns>
        public static bool operator >=(Student x, Student y)
        {
            if (ReferenceEquals(x, null))
                return false;

            return x.StudentID.CompareTo(y.StudentID) >= 0;
        }

        /// <summary>
        /// Compares Student objects based on parsed StudentIDs to int
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            if (other == null)
                return 1;

            return int.Parse(StudentID).CompareTo(int.Parse(other.StudentID));
        }
    }
}
