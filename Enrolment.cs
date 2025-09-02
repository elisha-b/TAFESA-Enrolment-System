﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    internal class Enrolment
    {
        private string dateEnrolled;
        private string grade;
        private int semester;
        private Subject subject;

        const string DEF_DATE_ENROLLED = "N/A";
        const string DEF_GRADE = "N/A";
        const int DEF_SEMESTER = -1;

        public string DateEnrolled { get; set; }

        public string Grade { get; set; }

        public int Semester { get; set; }

        public Subject Subject { get; set; }

        public Enrolment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER, new Subject()) { }

        public Enrolment(string dateEnrolled, string grade, int semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }

        public override string ToString()
        {
            return "Enrolment Date: " + DateEnrolled + "\nGrade: " + Grade + "\nSemester: " + Semester + "\n" + Subject;
        }
    }
}
