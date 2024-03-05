using System;
namespace Reverse
{
    internal class Array
    {
        static void Main()
        {
            string input = "hello";
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            Console.WriteLine("Reversed string: " + reversed);
        }
    }
}
