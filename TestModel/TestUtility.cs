using NUnit.Framework;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using TAFESA_Enrolment_System.Model;

namespace TestProject
{
    [TestFixture]
    class TestUtility
    {
        private Student[] students;
        private Student[] students_input;
        private Student[] students_expected;

        [SetUp]
        public void Setup()
        {
            // Search
            students = new Student[10000]; // Array of 10,000 student objects

            for (int i = 0; i < students.Length; i++) // Set student IDs 1-10,000
            {
                string id = $"{i + 1}";
                students[i] = new Student(id);
            }

            // Sort
            string[] temp = { "4", "53", "2", "35", "27", "3", "5", "7", "79", "13", "22", "6", "23" }; // Array of unsorted Student IDs
            students_input = new Student[temp.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                students_input[i] = new Student(temp[i]);
            }
        }

        [Test]
        public void LinearSearch()
        {
            Student target = new Student("6505"); // target Student ID 6505

            int search = Utility.LinearSearchArray(students, target); // sets Search to be the index of the Student object that has the ID 6505

            Assert.That(search, Is.EqualTo(int.Parse(target.StudentID) - 1)); // Since the first index is 0, assert that the found index is target - 1
        }
        [Test]
        public void BinarySearch()
        {
            Student target = new Student("6505"); // target Student ID 6505

            int search = Utility.BinarySearchArray(students, target); // sets Search to be the index of the Student object that has the ID 6505

            Assert.That(search, Is.EqualTo(int.Parse(target.StudentID) - 1)); // Since the first index is 0, assert that the found index is target - 1
        }
        [Test]
        public void AscBubbleSort()
        {
            string[] temp_expected = { "2", "3", "4", "5", "6", "7", "13", "22", "23", "27", "35", "53", "79" };
            //string[] temp_expected = { "79", "53", "35", "27", "23", "22", "13", "7", "6", "5", "4", "3", "2" };
            students_expected = new Student[temp_expected.Length];

            for (int i = 0; i < temp_expected.Length; i++)
            {
                students_expected[i] = new Student(temp_expected[i]);
            }

            Utility.AscBubbleSort(students_input);

            Assert.That(students_input, Is.EqualTo(students_expected));
        }
        [Test]
        public void DecBubbleSort()
        {
            string[] temp_expected = { "79", "53", "35", "27", "23", "22", "13", "7", "6", "5", "4", "3", "2" };
            //string[] temp_expected = { "2", "3", "4", "5", "6", "7", "13", "22", "23", "27", "35", "53", "79" };
            students_expected = new Student[temp_expected.Length];

            for (int i = 0; i < temp_expected.Length; i++)
            {
                students_expected[i] = new Student(temp_expected[i]);
            }

            Utility.DecBubbleSort(students_input);

            Assert.That(students_input, Is.EqualTo(students_expected));
        }
    }
}