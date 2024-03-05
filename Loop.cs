using System;
namespace Reverse
{
    internal class Loop
    {
        static void Main()
        {
            string str, rev = "";
            Console.WriteLine("Enter a String");
            str= Console.ReadLine();    
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev=rev+ str[i];
            }
            Console.WriteLine("Reversed string: " + rev);
        }
    }
}
