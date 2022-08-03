namespace SubstringWithConcatenation
{
    internal static class Validator
    {
        public static void Validate(string[] stringArray)
        {
            if (stringArray == null) throw new ArgumentNullException();
            if (stringArray.Length == 0) throw new ArgumentException();

            var wordLength = stringArray[0].Length;
            foreach (var word in stringArray)
            {
                if (word.Length != wordLength)
                    throw new ArgumentException("All words must be of same length");
            }
        }
    }
}
