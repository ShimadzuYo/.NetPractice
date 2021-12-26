namespace OopPracticeRefactored.Helpers
{
    public static class StringExtensions
    {
        // see
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
        public static string NormalizeInput(this string str)
        {
            return str.Trim().ToLower();
        }
    }
}