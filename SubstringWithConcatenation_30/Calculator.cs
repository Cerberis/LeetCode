namespace SubstringWithConcatenation
{
    public class Calculator
    {
        string GivenWord { get; set; }
        string[] WordArray { get; set; }

        readonly int WordArrayLength;
        readonly int SingleWordLength;

        public Calculator(string givenWord, string[] wordArray)
        {
            GivenWord = givenWord;
            WordArray = wordArray;
            WordArrayLength = wordArray.Length;
            SingleWordLength = wordArray[0].Length;
        }

        public IList<int> Calculate()
        {
            var foundChainIndexes = new List<int>();

            for (int i = 0; i < GivenWord.Length - (WordArrayLength * SingleWordLength-1); i++)
            {
                if (CheckIfChainExist(GivenWord.Substring(i,WordArrayLength * SingleWordLength)))
                    foundChainIndexes.Add(i);
            }
            return foundChainIndexes.ToArray();
        }
              
        bool CheckIfChainExist(string partOfGivenWord)
        {
            var splittedGivenWord = SplitStringIntoWords(partOfGivenWord);
            foreach (var usedWord in WordArray)
            {
                if (!splittedGivenWord.Contains(usedWord))
                {
                    return false;
                }
                else
                {
                    var foundIndex = splittedGivenWord.IndexOf(usedWord);
                    splittedGivenWord.RemoveAt(foundIndex);
                }
            }
            return true;
        }

        List<string> SplitStringIntoWords(string givenWord)
        {
            var splittedGivenWord = new List<string>();
            for (int i = 0; i < givenWord.Length; i += SingleWordLength)
            {
                splittedGivenWord.Add(givenWord.Substring(i, SingleWordLength));
            }
            return splittedGivenWord;
        }
    }
}
