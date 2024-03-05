using System;
namespace Reverse
{
    internal class Recursion
    {
        static void Main()
        {
            string input = "hello";
            string reversed = ReverseString(input);

            Console.WriteLine("Reversed string: " + reversed);
        }
        static string ReverseString(string str)
        {
            if (str == "")
                return str;
            else


                return ReverseString(str.Substring(1)) + str[0];
        }
    }
}
