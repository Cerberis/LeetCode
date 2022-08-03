namespace CommonCode.Extensions
{
    public static class StringExtensions
    {

        public static int[] ConvertToIntArray(this string s)
        {
            return ConvertToIntArray(s, ',');
        }

        public static int[] ConvertToIntArray(this string s, char splitSymbol)
        {
            var result = new List<int>();
            var stringArray = s.Split(splitSymbol, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in stringArray)
            {
                result.Add(int.Parse(item));
            }
            return result.ToArray();
        }

    }
}