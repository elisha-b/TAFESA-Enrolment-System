using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    abstract class Student
    {
        private string studentID;
        private string program;
        private string dateRegistered;

        const string DEF_STUDENT_ID = "N/A";
        const string DEF_PROGRAM = "N/A";
        const string DEF_DATE_REGISTERED = "N/A";

        public string StudentID { get; set; }

        public string Program { get; set; }

        public string DateRegistered { get; set; }

        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED) { }

        public Student(string studentID, string program, string dateRegistered)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
        }

        public override string ToString()
        {
            return "Student ID: " + StudentID + "\nProgram: " + Program + "\nDate Registered: " + DateRegistered;
        }
    }
}
