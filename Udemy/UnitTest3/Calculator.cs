using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo3
{
    public class Calculator
    {
        
        public int add(int a,int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int prod(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Dicision by Zero cannot divide by Zero");
            }
            return a / b;
            
            
        }
    }
}
