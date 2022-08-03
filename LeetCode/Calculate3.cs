namespace RomanToInteger
{
    public static class Calculate3
    {
        static readonly IReadOnlyDictionary<char, int> romanSingleNumbers = new Dictionary<char, int>
    {
         { 'm', 1000 },
         { 'd', 500 },
         { 'c', 100 },
         { 'l', 50 },
         { 'x', 10 },
         { 'v', 5 },
         { 'i', 1 }
};


        public static int Calculate(string givenRomanNumber)
        {
            givenRomanNumber = givenRomanNumber.Replace("cm", "dcccc").Replace("cd", "cccc").Replace("xc", "lxxxx").Replace("xl", "xxxx").Replace("ix", "viiii").Replace("iv", "iiii");
            return CalculateRomanSingleNumbers(givenRomanNumber);
        }

        static int CalculateRomanSingleNumbers(string givenRomanNumber)
        {
            var result = 0;
            foreach (var romanSingleNumber in romanSingleNumbers)
            {
                result += givenRomanNumber.Count(m => m.Equals(romanSingleNumber.Key)) * romanSingleNumber.Value;
            }
            return result;
        }
    }
}
