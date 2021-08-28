using System;
using System.Collections.Generic;
using System.Linq;

class demo
{
    static void Main()
    {
        Func<int, int,int > sum = (x, y) => x + y;
        Func<int, int> square = x => x * x;
        Func<int, int> cube = x => x * x * x;
        Func<int, int, int> sub = (x, y) => x - y;
        Console.WriteLine(square(4));
        Console.WriteLine(cube(3));
        Console.WriteLine(sum(3,6));
        Console.WriteLine(sub(9,3));

    }
}