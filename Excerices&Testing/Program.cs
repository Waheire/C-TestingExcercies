

using Excerices_Testing;

Questions func = new Questions();

//question 1
Console.WriteLine(func.reverseNumber(500)); // Output: 5
Console.WriteLine(func.reverseNumber(-56)); // Output: -65
Console.WriteLine(func.reverseNumber(-90)); // Output: -9
Console.WriteLine(func.reverseNumber(91));  // Output: 19

//Question 2
Console.Write("Enter a string: ");
string userInput = Console.ReadLine();
string capitalizedString = func.CapitalizeFirstLetter(userInput);
Console.WriteLine("Capitalized String: " + capitalizedString);

//Question 4
Console.Write("Enter a string: ");
string userInput_Palindrome = Console.ReadLine();

bool isPalindrome = func.isPalindrome(userInput_Palindrome);

if (isPalindrome)
{
    Console.WriteLine($"{userInput} is a palindrome.");
}
else
{
    Console.WriteLine($"{userInput} is not a palindrome.");
}

//Question 5
int[] array1 = { 1, 2, 3, 3, 4, 5, 6, 7 };
int chunkSize1 = 3;

int[] array2 = { 1, 2, 3, 5, 6, 7 };
int chunkSize2 = 1;

Console.WriteLine("Array 1: " + string.Join(", ", array1));
Console.WriteLine($"Chunk Size: {chunkSize1}");
func.PrintResult(func.chunckArray(array1, chunkSize1));

Console.WriteLine();

Console.WriteLine("Array 2: " + string.Join(", ", array2));
Console.WriteLine($"Chunk Size: {chunkSize2}");
func.PrintResult(func.chunckArray(array2, chunkSize2));


//Question 6
Console.WriteLine("Enter a string");
string input_Vowel = Console.ReadLine();

int vowelCount = func.CountVowels(input_Vowel);

Console.WriteLine($"Number of vowels in the entered string: {vowelCount}");

//Question 7
string input = "Sorry lorry driven inner inside into";
char maxChar = func.GetMostFrequentChar(input);
Console.WriteLine($"The most frequent character is: {maxChar}");

