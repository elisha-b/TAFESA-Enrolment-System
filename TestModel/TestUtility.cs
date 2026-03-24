using NUnit.Framework;
using TAFESA_Enrolment_System.Model;

namespace TestProject
{
    [TestFixture]
    class TestUtility
    {
        private Student[] students;

        [SetUp]
        public void Setup()
        {
            students = new Student[10];

            for (int i = 0; i < students.Length; i++)
            {
                string id = $"{i + 1}";
                students[i] = new Student(id);
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
    }
}