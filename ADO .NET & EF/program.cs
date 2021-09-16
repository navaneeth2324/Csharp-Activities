using FoodBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Food Ordering System");
            FoodBusinessLayer blObj = new FoodBusinessLayer();
            var customers = blObj.GetAllcustomers();
            foreach (var cust in customers)
            {
                Console.WriteLine(cust.First_Name + "|" + cust.Last_Name);
            }
        }
    }
}
