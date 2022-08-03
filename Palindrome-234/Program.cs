
using CommonCode.Extensions;
using Palindrome;

Console.WriteLine("Enter numbers seperated by comma");
var givenRomanNumber = Console.ReadLine();
if (string.IsNullOrEmpty(givenRomanNumber))
{
    throw new ArgumentNullException("Array can not be empty");
}

var numberArray = givenRomanNumber.ConvertToIntArray();
var result = Calculate1.Calculate(numberArray);
Console.WriteLine($"Is array palindromic: {result}");