namespace RomanToInteger
{
    public static class Calculate2
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
        static readonly IReadOnlyDictionary<string, string> romanJoinedNumbers = new Dictionary<string, string>
{
         {"cm","dcccc" },
         {"cd","cccc" },
         {"xc","lxxxx" },
         {"xl","xxxx" },
         {"ix", "viiii" },
         {"iv", "iiii" }
};



        public static int Calculate(string givenRomanNumber)
        {
            int result = 0;
            foreach (var romanJoinedNumber in romanJoinedNumbers)
            {
                givenRomanNumber = givenRomanNumber.Replace(romanJoinedNumber.Key, romanJoinedNumber.Value);
            }
            result += CalculateRomanSingleNumbers(givenRomanNumber);
            return result;
        }

        static int CalculateRomanSingleNumbers(string givenRomanNumber)
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
