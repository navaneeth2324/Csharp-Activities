using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class swap
    {
        
            static void SwapStrings(ref string s1, ref string s2)
            // The string parameter is passed by reference.
            // Any changes on parameters will affect the original variables.
            {
                string temp = s1;
                s1 = s2;
                s2 = temp;
                System.Console.WriteLine("Inside the method: {0} {1}", s1, s2);
            }

            static void Main()
            {
                string str1 = "John";
                string str2 = "Cena";
                System.Console.WriteLine("Inside Main, before swapping: {0} {1}", str1, str2);

                SwapStrings(ref str1, ref str2);   // Passing strings by reference
                System.Console.WriteLine("Inside Main, after swapping: {0} {1}", str1, str2);
            }
        
    }
}
