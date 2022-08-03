namespace CommonCode.Extensions
{
    public static class StringExtensions
    {

        public static int[] GetIntArray(this string s)
        {
            return GetIntArray(s, ',');
        }

        public static int[] GetIntArray(this string s, char splitSymbol)
        {
            var result = new List<int>();
            var stringArray = s.Split(splitSymbol, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in stringArray)
            {
                result.Add(int.Parse(item));
            }
            return result.ToArray();
        }

        public static string[] GetStringArray(this string s)
        {
            return GetStringArray(s, ',');
        }

        public static string[] GetStringArray(this string s, char splitSymbol)
        {
            return s.Split(splitSymbol, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}