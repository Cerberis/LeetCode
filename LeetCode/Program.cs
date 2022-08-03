
using RomanToInteger;



var givenRomanNumber = Console.ReadLine();
if (string.IsNullOrEmpty(givenRomanNumber))
{
    throw new ArgumentNullException("Number cannot be empty");
}

int result = Calculate2.Calculate(givenRomanNumber.ToLower());
Console.WriteLine($"Result is {result}");