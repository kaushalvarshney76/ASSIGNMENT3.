using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class program9
    {
        protected int age;
        public String name;
        public program9(int age, String name)
        {
            this.age = age;
            this.name = name;
        }
        protected void getempinfo()
        {
            Console.WriteLine($"the employee name is {name} and age is {age}");
        }
    }
    internal class Dev1 : program9
    {
        internal Dev1() : base(24, "amit")
        { }
        public void Print3()
        {
            Console.WriteLine("it is print method of Dev class");
            getempinfo();
        }

    }
}