
using CommonCode.Extensions;
using SubstringWithConcatenation;

Console.WriteLine("Enter string");
var giveWord = Console.ReadLine();
if (string.IsNullOrEmpty(giveWord))
{
    throw new ArgumentNullException("Given word can not be empty");
}

Console.WriteLine("Enter string list seperated by comma. All words need to be same length.");
var wordList = Console.ReadLine();
if (string.IsNullOrEmpty(wordList))
{
    throw new ArgumentNullException("Word list can not be empty");
}

var wordArray = wordList.GetStringArray();

Validator.Validate(wordArray);

var calculator = new Calculator(giveWord, wordArray);
var result = calculator.Calculate();
Console.WriteLine($"Chains found at indexes: {string.Join(", ", result)}");