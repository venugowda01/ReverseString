using System;
namespace Reverse
{
    internal class StringBuilder
    {
        static void Main()
        {
            string input = "hello";
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            string reversed = sb.ToString();
            Console.WriteLine("Reversed string: " + reversed);
        }
    }
}
