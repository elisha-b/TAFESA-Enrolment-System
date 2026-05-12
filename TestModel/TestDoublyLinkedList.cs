using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESA_Enrolment_System.Model;

namespace TAFESA_Enrolment_System.TestDoublyLinkedList
{
    [TestFixture]
    class TestDoublyLinkedList
    {
        private Model.DoublyLinkedList<Student> studentList;

        [SetUp]
        public void SetUp()
        {
            studentList = new Model.DoublyLinkedList<Student>();

            string[] temp = { "12", "15", "34", "64", "25", "23", "11", "45", "22" }; // 12 (Head); 22 (Tail)

            // Create studentList of student objects with IDs from temp array of strings
            for (int i = 0; i < temp.Length; i++)
            {
                studentList.AddLast(new Student(temp[i]));
            }
        }

        [Test]
        public void StudentAddFirst()
        {
            Student newHead = new Student("99"); // Adding Student with ID 99
            studentList.AddFirst(newHead);

            // Put the Student IDs into a new list to check structure after insertion
            List<string> ids = new List<string>();
            foreach (var student in studentList)
            {
                ids.Add(student.StudentID);
            }

            Assert.That(ids[0], Is.EqualTo(newHead.StudentID)); // New head
            Assert.That(ids[1], Is.EqualTo(new Student("12").StudentID)); // Previous head
        }

        [Test]
        public void StudentAddLast()
        {
            Student newTail = new Student("99"); // Adding Student with ID 99
            studentList.AddLast(newTail);

            // Put the Student IDs into a new list to check structure after insertion
            List<string> ids = new List<string>();
            foreach (var student in studentList)
            {
                ids.Add(student.StudentID);
            }

            Assert.That(ids[ids.Count - 1], Is.EqualTo(newTail.StudentID)); // New tail
            Assert.That(ids[ids.Count - 2], Is.EqualTo(new Student("22").StudentID)); // Previous tail
        }

        [Test]
        public void StudentFind()
        {
            Student target = new Student("34"); // Student with ID 34

            Assert.That(studentList.Contains(target), Is.EqualTo(true)); // Assert that target exists in studentList
        }

        [Test]
        public void StudentRemoveFirst()
        {
            studentList.RemoveFirst();

            // Put the Student IDs into a new list to check structure after deletion
            List<string> ids = new List<string>();
            foreach (var student in studentList)
            {
                ids.Add(student.StudentID);
            }

            Assert.That(studentList.Contains(new Student("12")), Is.EqualTo(false)); // Head is deleted
            Assert.That(ids[0], Is.EqualTo(new Student("15").StudentID)); // New head is 15
        }

        [Test]
        public void StudentRemoveLast()
        {
            studentList.RemoveLast();

            // Put the Student IDs into a new list to check structure after deletion
            List<string> ids = new List<string>();
            foreach (var student in studentList)
            {
                ids.Add(student.StudentID);
            }

            Assert.That(studentList.Contains(new Student("22")), Is.EqualTo(false)); // Tail is deleted
            Assert.That(ids[ids.Count - 1], Is.EqualTo(new Student("45").StudentID)); // New tail is 45
        }
    }
}
