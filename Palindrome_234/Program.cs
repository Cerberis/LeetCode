
using CommonCode.Extensions;
using Palindrome;

Console.WriteLine("Enter numbers seperated by comma");
var givenRomanNumber = Console.ReadLine();
if (string.IsNullOrEmpty(givenRomanNumber))
{
    throw new ArgumentNullException("Array can not be empty");
}

var numberArray = givenRomanNumber.GetIntArray();
var result = Calulator.Calculate(numberArray);
Console.WriteLine($"Is array palindromic: {result}");