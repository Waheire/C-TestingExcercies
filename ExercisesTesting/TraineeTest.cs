using Excerices_Testing;
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
        public void AddStudent_AddStudentToList_ShouldAddStudent(string fullName)
        {
            trainee.addStudent(fullName);
            Assert.That(trainee._studentList, Is.EquivalentTo(new List<string>() { fullName }));
        }

        [Test]
        [TestCase("")]
        [TestCase("     ")]
        [TestCase(null)]
        public void removeStudent_CheckInputIfNullWhiteSpace_ShouldThrowError(string fullName)
        {
            Assert.That(() => trainee.removeStudent(fullName), Throws.TypeOf<ArgumentNullException>());
        }

        //[Test]
        //[TestCase("Christopher Nolan")]
        
        //public void removeStudent_RemoveEnteredStudentNameFromList_ShouldRemoveStudentFromList(string fullName)
        //{
        //    trainee.removeStudent(fullName);
        //    Assert.That(trainee._studentList, Is.EquivalentTo(new List<string>() { fullName }));
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
        //[TestCase("Christopher Nolan")]
        //public void SearchStudent_SearchEnteredStudentNameFromList_ShouldShowStudentNameFromList(string fullName)
        //{
        //    trainee.SearchStudent(fullName);
        //    Assert.That(trainee._studentList, Is.EquivalentTo(new List<string>() { fullName }));
        //}

      

    }
}
