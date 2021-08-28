using System;

Func<int, int> square = x => x * x;
Func<int, int> cube = x => x * x * x;
Func<int, int> inc = x => x++;
Func<int, int, int> add = (x, y) => x + y;

Console.WriteLine(square(5));
Console.WriteLine(cube(5));
Console.WriteLine(inc(5));
Console.WriteLine(add(5, 7));