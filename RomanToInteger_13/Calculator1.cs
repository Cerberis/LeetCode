namespace RomanToInteger
{
    public class Calculator1 : ICalculator
    {
        readonly IReadOnlyDictionary<char, int> romanSingleNumbers = new Dictionary<char, int>
    {
         { 'm', 1000 },
         { 'd', 500 },
         { 'c', 100 },
         { 'l', 50 },
         { 'x', 10 },
         { 'v', 5 },
         { 'i', 1 }
};
        readonly IReadOnlyDictionary<string, int> romanJoinedNumbers = new Dictionary<string, int>
{
         {"cm",900 },
         {"cd",400 },
         {"xc",90 },
         {"xl",40 },
         {"ix", 9 },
         {"iv", 4 }
};

        public int Calculate(string givenRomanNumber)
        {
            int result = 0;
            foreach (var romanJoinedNumber in romanJoinedNumbers)
            {
                if (givenRomanNumber.Contains(romanJoinedNumber.Key))
                {
                    result += romanJoinedNumber.Value;
                    givenRomanNumber = givenRomanNumber.Replace(romanJoinedNumber.Key, String.Empty);
                }
            }
            result += CalculateRomanSingleNumbers(givenRomanNumber);
            return result;
        }

        int CalculateRomanSingleNumbers(string givenRomanNumber)
        {
            var result = 0;
            foreach (var romanSingleNumber in romanSingleNumbers)
            {
                result += givenRomanNumber.ToArray().Count(m => m.Equals(romanSingleNumber.Key)) * romanSingleNumber.Value;
            }
            return result;
        }
    }
}
