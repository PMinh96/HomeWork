

using Homework.Common.Constants;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Homework.Common.Utils
{
    public static class AppUtlis
    {
        public static string GetValueFromKeyboard(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine() ?? string.Empty;
        }

        public static int ConvertValueTo(string value)
        {
            return int.TryParse(value, out var output) ? output : 0;
        }

        public static void PrintSeparator()
        {
            Console.WriteLine("===================================================================");
        }
        public static void PrintOption()
        {   
            var count = 1;

            foreach (string option in OptionConstants.Options)
            {
                Console.WriteLine($"{count}, {option}");
                count++;
            }
        }
    }
}
