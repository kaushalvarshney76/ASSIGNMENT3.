using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class program3
    {
        protected String Name;
        protected int Sellery;

        protected program3(String Name, int Sellery)
        {
            this.Sellery = Sellery;
            this.Name = Name;

        }

        protected void Print()
        {
            Console.WriteLine($"The employee name is {Name} and sellery of the emp is {Sellery}");
        }
    }
    internal class Child : program3
    {
        public String City;

        protected Child(string City) : base("amit", 250000)
        {

            this.City = City;
        }

        public static void Main(String[] args)
        {
            Child c1 = new Child("Agra");
            Console.WriteLine(c1.City);

            c1.Print();
            Console.ReadLine();
        }



    }
}