using System;
using System.Linq;
namespace Reverse
{
    internal class Linq
    {
        static void Main()
        {
            string input = "hello";
            string reversed = new string(input.Reverse().ToArray());

            Console.WriteLine("Reversed string: " + reversed);
        }
    }
}
