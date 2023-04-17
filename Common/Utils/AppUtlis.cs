

namespace Homework.Common.Utils
{
    public static class AppUtlis
    {
        public static string GetValueFromKeyboard(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
