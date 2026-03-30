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
            students = new Student[10];

            for (int i = 0; i < students.Length; i++)
            {
                string id = $"{i + 1}";
                students[i] = new Student(id);
            }

            // Sort
            string[] temp = { "4", "53", "2", "35", "27", "3", "5", "7", "79", "13", "22", "6", "23" };
            students_input = new Student[temp.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                students_input[i] = new Student(temp[i]);
            }
        }

        [Test]
        public void LinearSearch()
        {
            Student target = new Student("7");

            int search = Utility.LinearSearchArray(students, target);

            Assert.That(search, Is.EqualTo(6));
        }
        [Test]
        public void BinarySearch()
        {
            Student target = new Student("7");

            int search = Utility.BinarySearchArray(students, target);

            Assert.That(search, Is.EqualTo(6));
        }
        [Test]
        public void AscBubbleSort()
        {
            string[] temp_expected = { "13", "2", "22", "23", "27", "3", "35", "4", "5", "53", "6", "7", "79" };
            students_expected = new Student[temp_expected.Length];

            for (int i = 0; i < temp_expected.Length; i++)
            {
                students_expected[i] = new Student(temp_expected[i]);
            }

            Utility.AscBubbleSort(students_input);

            Assert.That(students_expected, Is.EqualTo(students_expected));
        }
        [Test]
        public void DecBubbleSort()
        {
            string[] temp_expected = { "79", "7", "6", "53", "5", "4", "35", "3", "27", "23", "22", "2", "13" };
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