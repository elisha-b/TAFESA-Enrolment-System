using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESA_Enrolment_System.Model;

namespace TAFESA_Enrolment_System.TestBinaryTree
{
    [TestFixture]
    class TestBinaryTree
    {
        private BinaryTree<Student> binaryTree;
        private List<Student> binaryTreePre;
        private List<Student> binaryTreeIn;
        private List<Student> binaryTreePost;

        [SetUp]
        public void SetUp()
        {
            // Original
            binaryTree = new BinaryTree<Student>();

            string[] temp = { "4", "2", "6", "1", "5", "3", "7", };
            for (int i = 0; i < temp.Length; i++)
            {
                binaryTree.Add(new Student(temp[i]));
            }

            // PreOrder List
            binaryTreePre = new List<Student>();

            string[] tempPre = { "4", "2", "1", "3", "6", "5", "7", };
            for (int i = 0; i < tempPre.Length; i++)
            {
                binaryTreePre.Add(new Student(tempPre[i]));
            }

            // InOrder List
            binaryTreeIn = new List<Student>();

            string[] tempIn = { "1", "2", "3", "4", "5", "6", "7", };
            for (int i = 0; i < tempIn.Length; i++)
            {
                binaryTreeIn.Add(new Student(tempIn[i]));
            }

            // PostOrder List
            binaryTreePost = new List<Student>();

            string[] tempPost = { "1", "3", "2", "5", "7", "6", "4", };
            for (int i = 0; i < tempPost.Length; i++)
            {
                binaryTreePost.Add(new Student(tempPost[i]));
            }

        }
        [Test]
        public void PreOrder()
        {
            // Taking console result into a string using StringWriter and Console.SetOut
            var output = new StringWriter();
            Console.SetOut(output);

            binaryTree.TraversePreOrder(binaryTree.Root);

            string temp = output.ToString();

            // Take only Student ID from output student objects and put them all into a list
            var result = temp.Split('\n').Where(line => line.StartsWith("Student ID: ")).Select(line => line.Replace("Student ID: ", "")).ToList();

            // Take only Student ID from expected student objects and put them all into a list
            var expected = binaryTreePre.Select(s => s.StudentID).ToList();

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void InOrder()
        {
            // Taking console result into a string using StringWriter and Console.SetOut
            var output = new StringWriter();
            Console.SetOut(output);

            binaryTree.TraverseInOrder(binaryTree.Root);

            string temp = output.ToString();

            // Take only Student ID from output student objects and put them all into a list
            var result = temp.Split('\n').Where(line => line.StartsWith("Student ID: ")).Select(line => line.Replace("Student ID: ", "")).ToList();

            // Take only Student ID from expected student objects and put them all into a list
            var expected = binaryTreeIn.Select(s => s.StudentID).ToList();

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PostOrder()
        {
            // Taking console result into a string using StringWriter and Console.SetOut
            var output = new StringWriter();
            Console.SetOut(output);

            binaryTree.TraversePostOrder(binaryTree.Root);

            string temp = output.ToString();

            // Take only Student ID from output student objects and put them all into a list
            var result = temp.Split('\n').Where(line => line.StartsWith("Student ID: ")).Select(line => line.Replace("Student ID: ", "")).ToList();

            // Take only Student ID from expected student objects and put them all into a list
            var expected = binaryTreePost.Select(s => s.StudentID).ToList();

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
