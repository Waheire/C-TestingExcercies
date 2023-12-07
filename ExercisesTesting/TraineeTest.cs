using Excerices_Testing;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesTesting
{
    [TestFixture]
    public class TraineeTest
    {
        private Trainee trainee;
        [SetUp]
        public void setup()
        {
            trainee = new Trainee();
        }
     
        [Test]
        [TestCase("")]
        [TestCase("     ")]
        [TestCase(null)]
        public void AddStudent_CheckInputIfNullWhiteSpace_ShouldThrowError(string fullName)
        {
            Assert.That(() => trainee.addStudent(fullName), Throws.TypeOf<ArgumentNullException>());
        }

    
        [Test]
        [TestCase("Christopher Nolan")]
        public void AddStudent_WhenNameEnteredDoesNotExistInList_ShouldAddStudentName(string fullName)
        {
            trainee.addStudent(fullName);
            trainee.SearchStudent(fullName);
            trainee.removeStudent(fullName);
            Assert.That(trainee._studentList, Is.Empty);
        }

        [Test]
        [TestCase("Christopher Nolan")]
        public void AddStudent_WhenNameEnteredDoesExistInList_ShouldThrowError(string fullName)
        {
            trainee.addStudent(fullName);
            Assert.Throws<InvalidOperationException>(() => trainee.addStudent(fullName));
        }

        [Test]
        [TestCase("")]
        [TestCase("     ")]
        [TestCase(null)]
        public void removeStudent_CheckInputIfNullWhiteSpace_ShouldThrowError(string fullName)
        {
            Assert.That(() => trainee.removeStudent(fullName), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        [TestCase("Obama Barack")]
        public void removeStudent_WhenEnteredStudentNameDoesNotExists_ShouldThrowError(string fullName)
        {
            Assert.Throws<InvalidOperationException>(() => trainee.removeStudent(fullName));
        }

        //[Test]
        //[TestCase("Obama Barack")]
        //public void removeStudent_WhenEnteredNameExists_ShouldRemoveNameFromList(string fullName)
        //{
        //    Assert.That(() => trainee.removeStudent(fullName), Is.EquivalentTo(new List<string>() { fullName }));
        //}

        [Test]
        [TestCase("")]
        [TestCase("     ")]
        [TestCase(null)]
        public void SearchStudent_CheckInputIfNullWhiteSpace_ShouldThrowError(string fullName)
        {
            Assert.That(() => trainee.SearchStudent(fullName), Throws.TypeOf<ArgumentNullException>());
        }

        //[Test]
        //[TestCase("Ruth Waheire", "Ruth Waheire")]
        //public void SearchStudent_WhenEnteredNameDoesExist_ShouldReturnStudentName(string fullName, string output)
        //{
        //    var result = trainee.SearchStudent(fullName);
        //    Assert.That(result, Is.EquivalentTo(output));
        //}

        [Test]
        [TestCase("Ruth Waheire")]
        public void SearchStudent_WhenEnteredNameDoesNotExis_ShouldReturnEmpty(string fullName)
        {
            Assert.That(() => trainee.SearchStudent(fullName), Is.Empty);
        }

      

    }
}