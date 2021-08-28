using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo2
{
    public class Voting
    {
        string name;
        int age;
        public Voting(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public string IsEligible(int age)
        {
            if (age < 18)
                return "Not Eligible";
            else if (age == 18)
                return "Eligible";
            return "Eligible";

        }
    }
}
