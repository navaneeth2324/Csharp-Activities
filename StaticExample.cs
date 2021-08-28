using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCsharp
{
    static class StaticExamples  //Static Class
    {
        public static string name; //Static Variables
        public static int age;
        public static double height;
        public static double weight;

        public static void DisplayDetails()  //Static Method
        {
            Console.WriteLine("Hi "+name);
            Console.WriteLine("Your Age: "+age);
            Console.WriteLine("Your Height: "+height);
            Console.WriteLine("Your Weight: "+weight);
        }
        static public void Main()   //Static Main
        {
            Console.Write("Name: ");
            StaticExamples.name = Console.ReadLine();
            Console.Write("Age: ");
            StaticExamples.age = Convert.ToInt32(Console.ReadLine());   //For all static classes all its member functions and variables can be accesses without creating an instance of the class
            Console.Write("Height: ");
            StaticExamples.height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Weight: ");
            StaticExamples.weight = Convert.ToDouble(Console.ReadLine());
            StaticExamples.DisplayDetails();

        }
    }
    

}
