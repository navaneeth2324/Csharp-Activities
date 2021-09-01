using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    class ThreadExample
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            //By Default the Thread does not have any name
            //if you want then you can provide the name explicitly
            t.Name = "Main Thread";
            Console.WriteLine("Current Executing Thread Name :" + t.Name);
            Console.WriteLine("Current Executing Thread Name :" + Thread.CurrentThread.Name);
            Console.Read();
        }
    }
}
