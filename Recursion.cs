using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Recursion
    {
        public static int RecursiveSum(int n, int m)
        {
            int sum = n;
            if (n < m)
            {
                n++;
                return sum += RecursiveSum(n, m);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int sum = RecursiveSum(n, m);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
