using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class LinqExamples
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 1, 5, 3, 6, 7, 8, 11, 23, 43, 55 };
            var oddnumbers = from n in numbers
                             where n % 2 == 1
                             orderby n descending
                             select n;
            var evennumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine(String.Join(",", oddnumbers));
            Console.WriteLine(String.Join(",", evennumbers)); //using lambda expressions
        }
    }
   
}

