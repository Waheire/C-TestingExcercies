using Excerices_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesTesting
{
    [TestFixture]
    public class ExcericesTesting
    {
        private Questions que;
        [SetUp]
        public void Setup()
        {
            que = new Questions();
        }

        //Question 1 Test Case
        [Test]
        [TestCase(643, 346)]
        public void reverseNumber_WhenGivenNumbers_ShouldReturnReverseOfNumbers(int numbers, int output)
        {
            var result = que.reverseNumber(numbers);
            Assert.That(result, Is.EqualTo(output));
        }

        //Question 2 Test case 
        [Test]
        [TestCase("hello there", "Hello There")]
        [TestCase("arthur", "Arthur")]
        public void CapitalizeFirstLetter_WhenGivenStrings_ReturnFirstLetterOFEachStringCapitalized(string input, string output)
        {
            var result = que.CapitalizeFirstLetter(input);
            Assert.That(result, Is.EqualTo(output));
        }

        //Question 4
        [Test]
        [TestCase("level", true)]
        [TestCase("Out", false)]
        public void isPalindrome_WhenGivenAString_ReturnIfItQualifysAsAPalindrome(string userinput, bool output)
        {
            var result = que.isPalindrome(userinput);
            Assert.That(result, Is.EqualTo(output));
        }

        //Question 5
        [Test]
        public void chunckArray_GivenSizeOfSubArrays_ReturnSubArrayOfGivenLength() 
        {
            // Arrange
            int[] sampleArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int chunkSize = 3;
            var expectedResult = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 }
        };
            //Act
            var result = que.chunckArray(sampleArray, chunkSize);
            Assert.That(result, Is.EquivalentTo(expectedResult));
        }

        //Question 6
        [Test]
        [TestCase("Arthur", 2)]
        public void CountVowels_GivenAstring_ReturnNumberOfVowelsInString(string input, int output)
        {
            var result = que.CountVowels(input);
            Assert.That(result, Is.EqualTo(output));
        }

        //Question 7 
        [Test]
        [TestCase("lorry", 'r')]
        public void GetMostFrequentChar_GivenAstring_ReturnMostFrequentChar(string input , char output) 
        {
            var result = que.GetMostFrequentChar(input);
            Assert.That (result, Is.EqualTo(output));
        }



    }
}
