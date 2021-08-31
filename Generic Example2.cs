using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class GenericExample2
    {
        static void Main(string[] args)
        {
            // index based generic collection (arraylist)  
            List<int> listObj = new List<int>();
            listObj.Add(123);
            listObj.Add(235);
            // Displaying list value using index  
            Console.WriteLine("List Second Value: {0}", listObj[1]);
            // Key based generic Collection (Dictionary)  
            Dictionary<int, string> objDic = new Dictionary<int, string>();
            objDic.Add(123, "Ramakrishna");
            // Displaying Dictionary value using Key  
            Console.WriteLine("Dictionary Value: {0}", objDic[123]);
            // Priority based Generic Collection (Stack)  
            Stack<int> objStack = new Stack<int>();
            objStack.Push(1);
            objStack.Push(2);
            objStack.Push(3);
            // Display first value from Stack  
            Console.WriteLine("First Get Value from Stack: {0}", objStack.Pop());
            // Priority based Generic Collection (Queues)  
            Queue<int> objQueue = new Queue<int>();
            objQueue.Enqueue(1);
            objQueue.Enqueue(2);
            objQueue.Enqueue(3);
            // Display first value from Stack  
            Console.WriteLine("First Get Value from Queue: {0}", objQueue.Dequeue());
            Console.WriteLine();
            // Creating Employee records  
            Student sobj1 = new Student();
            sobj1.RegNo = 1001;
            sobj1.Name = "Navneeth";
            sobj1.Branch = "CSE";
            Student sobj2 = new Student();
            sobj2.RegNo = 1002;
            sobj2.Name = "Vishal";
            sobj2.Branch = "ECE";
            // Creating generic List with Employee records  
            List<Student> stuListObj = new List<Student>();
            stuListObj.Add(sobj1);
            stuListObj.Add(sobj2);
            // Displaying employee records from list collection  
            foreach (Student stu in stuListObj)
            {
                Console.WriteLine($"Student Reg No:{stu.RegNo}");
                Console.WriteLine($"Student Name:{stu.Name}");
                Console.WriteLine($"Student Branch:{stu.Branch}");
                Console.WriteLine();
            }
            Console.Read();
        }
        public class Student
        {
            public int RegNo;
            public string Name;
            public string Branch;
        }
    }
}
