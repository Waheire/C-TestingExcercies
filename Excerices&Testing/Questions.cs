using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerices_Testing
{
    public class Questions
    {
        //Question 1
        //Given an integer, return an integer that is reverse ordering the numbers  eg,
        //500 = 5 , -56 = -65, -90 = -9 , 91  = 19 
        public int reverseNumber(int number)
        {
            //change int to character array
            char[] digits = Math.Abs(number).ToString().ToCharArray();

            //reverse
            Array.Reverse(digits);

            //change to interger
            int reversedNumber = int.Parse(new string(digits));

            //restore sign of original number
            return (number < 0) ? -reversedNumber : reversedNumber;
        }

        //Question 2
        //Write a method that accepts a string, and the program should capitalize the first letter of each word in
        //the string then return the results string. 
        //e.g. hello there should be Hello There 
        // hi should be Hi 
        public string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Capitalize the first letter 
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string result = textInfo.ToTitleCase(input);
            return result;
        }

        //Question 4
        //Write a C# program that prompts the user to enter a string and determines whether the entered string is 
        //a palindrome. A palindrome is a sequence of characters that reads the same forward and backward, 
        //ignoring case and non-alphanumeric characters. E.g. level 

        public bool isPalindrome(string input)
        {
            //remove non-alphanumeric characters and change to lowercase
            string editedSampleString = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            //compare
            if (editedSampleString != new string(editedSampleString.Reverse().ToArray())) 
            {
                return false;
            }
            return true;
       
        }

        //Question 5
        //Given an array and chunk size divide the array into subarrays where each subarray is of length is the
        //chunk size.E.g.
        //[1,2,3,3,4,5,6,7],3)  ===[ [ 1, 2, 3 ], [ 3, 4, 5 ], [ 6, 7 ] ] 
        //([1,2,3,5,6,7],1) ===[ [ 1 ], [ 2 ], [ 3 ], [ 5 ], [ 6 ], [ 7 ] ] 

        public List<List<T>> chunckArray<T>(T[] array, int chunckSize)
        {
            List<List<T>> result = new List<List<T>>();

            for (int i = 0; i < array.Length; i += chunckSize)
            {
                List<T> chunk = array.Skip(i).Take(chunckSize).ToList();
                result.Add(chunk);
            }
            return result;
        }

        public void PrintResult<T>(List<List<T>> result)
        {
            foreach (var chunck in result)
            {
                Console.WriteLine("{ " + string.Join(", ", chunck) + " ]");
            }

        }

        //Questions 6
        //Write a C# program that prompts the user to enter a string and counts the number of vowels in the entered string. 
        //Vowels are the letters 'a', 'e', 'i', 'o', and 'u' (both uppercase and lowercase). 

        public int CountVowels(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                // Check if the character is a vowel (both uppercase and lowercase)
                if ("aeiouAEIOU".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        //Question 7
        //Write C# program that return the  most appearing character in a value 
        //Eg 11189 => '1' 
        //jonathan => n 
        public char GetMostFrequentChar(string input)
        {
            var charCounts = input
                .GroupBy(c => c)
                .ToDictionary(group => group.Key, group => group.Count());

            char maxChar = charCounts.FirstOrDefault(x => x.Value == charCounts.Values.Max()).Key;
            return maxChar;
        }

    }
}
