namespace OopPracticeRefactored.Helpers
{
    public static class StringExtensions
    {
        public static string NormalizeInput(this string str)
        {
            return str.Trim().ToLower();
        }
    }
}