using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class GenericExamples
    {
        static void Main(string[] args)
        {
            // Compare Integer  
            Check<int> obj1 = new Check<int>();
            bool intResult = obj1.Compare(3, 3);
            // Compare String  
            Check<string> obj2 = new Check<string>();
            bool strResult = obj2.Compare("Navaneeth", "Ramakrishna");
            Check<Double> obj3 = new Check<Double>();
            bool doubleresult=obj3.Compare(10.5, 2.5);
            Console.WriteLine("Integer Comparison: {0}\nString Comparison: {1} \nDouble Comparison: {2}", intResult, strResult,doubleresult);
            Console.Read();
        }
        
        // Generic class to accept all types of data types  
        class Check<unknown>
        {

            public bool Compare(unknown var1, unknown var2)
            {
                if (var1.Equals(var2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
