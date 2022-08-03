
using RomanToInteger;

var givenRomanNumber = Console.ReadLine();
if (string.IsNullOrEmpty(givenRomanNumber))
{
    throw new ArgumentNullException("Number cannot be empty");
}

ICalculator calculator = new Calculator2();
int result = calculator.Calculate(givenRomanNumber.ToLower());
Console.WriteLine($"Result is {result}");