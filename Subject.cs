using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    internal class Subject
    {
        private string subjectCode;
        private string subjectName;
        private double cost;

        const string DEF_SUBJECT_CODE = "N/A";
        const string DEF_SUBJECT_NAME = "N/A";
        const double DEF_COST = 0.0;

        public string SubjectCode { get; set; }

        public string SubjectName { get; set; }

        public double Cost { get; set; }

        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST) { }

        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        public override string ToString()
        {
            return "Subject Code: " + SubjectCode + "\nSubject Name: " + SubjectName + "\nCost: $" + Cost;
        }
    }
}
