using FoodBL;
using FoodDTO;
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
            Console.WriteLine("DataReader");
            FoodBusinessLayer blObj = new FoodBusinessLayer();
            var customers = blObj.GetAllEmployees();
            foreach (var cust in customers)
            {
                Console.WriteLine(cust.First_Name + " " + cust.Last_Name+"--"+cust.Address);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SQLAdapter");
            var result = blObj.FetchEmployeeDetails();
            foreach (var item in result)
            {
                Console.WriteLine(item.First_Name + "|" + item.Last_Name + "|" + item.Address + "|" + item.Contact_number + "|" + item.Email_address);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Update Employee Address With Employee ID");

            Console.WriteLine("Enter Employee ID: ");
            int eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Address: ");
            string eaddress = Console.ReadLine();
            customerDTO p = new customerDTO()
            {
                Emp_id = eid,
                Address = eaddress
            };
            int retvalue = blObj.UpdateEmployee(p);
            if (retvalue == -1)
            {
                Console.WriteLine("Please Enter  Employee ID!!");
            }
            else if(retvalue == -2)
            {
                Console.WriteLine("Address Cannot be Null!");
            }
            else if (retvalue == -99)
            {
                Console.WriteLine("OOPS!! Something went wrong!!!");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Insert into Employee ");
            Console.WriteLine("Enter EmployeeID: ");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Name: ");
            string fn = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string ln = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int ag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Address: ");
            string add = Console.ReadLine();
            Console.WriteLine("Enter Contact Number: ");
            string num = Console.ReadLine();
            Console.WriteLine("Enter Email Address: ");
            string mail = Console.ReadLine();
            customerDTO u = new customerDTO()
            {
                Emp_id = empid,
                First_Name = fn,
                Last_Name = ln,
                 Age= ag,
                Address = add,
                Contact_number = num,
                Email_address = mail
            };
            int rvalue = blObj.InserttIntoEmployeeDB(u);
            if (rvalue == -1)
            {
                Console.WriteLine("Please Enter All the Details!!");
            }
            else if (rvalue == -99)
            {
                Console.WriteLine("OOPS!! Something went wrong!!!");
            }
        }
    }
}
