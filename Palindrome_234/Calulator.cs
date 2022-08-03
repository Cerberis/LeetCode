namespace Palindrome
{
    public static class Calulator
    {
        public static bool Calculate(int[] numberList)
        {
            if (numberList.Length == 0)
            {
                throw new ArgumentNullException();
            }
            var middlePoint = numberList.Length / 2;
            var arrayLength = numberList.Length;

            for (int i = 0; i <= middlePoint; i++)
            {
                if (numberList[i] != numberList[arrayLength - i - 1])
                    return false;
            }
            return true;
        }
    }
}
