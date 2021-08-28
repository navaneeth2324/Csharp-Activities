using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCsharp
{
    class lambda2
    {
        static void Main()
        {
            Action<string> greet = name =>
            {
                string msg = $"Welcome!! {name}";
                Console.WriteLine(msg);
            };
            Console.WriteLine("Whats your Name ");
            string ip=Console.ReadLine();
            greet(ip);

            int[] vals = { 1, -2, 3, 4, 0, -3, 2, 1, 3 };

            var v1 = Array.FindIndex(vals, x => x == 3);//here the 2nd arguement (Matching condition) is in the form of a lambda expression.
            Console.WriteLine(v1);

            var v2 = Array.FindLastIndex(vals, x => x == 3);//here the 2nd arguement(Matching condition) is in the form of a lambda expression.
            Console.WriteLine(v2);

            var positive = Array.FindAll(vals, x => x > 0);//here the 2nd arguement (Matching condition) is in the form of a lambda expression.
            Console.WriteLine(string.Join(",", positive));


            var li = new List<int> { -1, 2, -2, 0, 3, 4, -5 };//using lists and with LINQ methods(select and where) 

            var squared = li.Select(x => x * x);
            Console.WriteLine(string.Join(", ", squared));

            var filtered = li.Where(x => x > 0);
            Console.WriteLine(string.Join(", ", filtered));


            //Array of Lambda Expressions
            var funs = new Func<int, int>[]
            {
                x => x * x,
                x => ++x,
                x => --x
            };

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(funs[0](i));
                Console.WriteLine(funs[1](i));
                Console.WriteLine(funs[2](i));
                Console.WriteLine();
            }

        }

    }
}
