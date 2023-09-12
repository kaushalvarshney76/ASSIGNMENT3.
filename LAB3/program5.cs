using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class program5
    {
        protected internal String name;
        protected internal String city;
        protected int age = 22;
        protected int account = 987456;

        protected program5(String name, String city)
        {
            this.name = name;
            this.city = city;
        }
        protected internal void GetUserInfo()
        {
            Console.WriteLine($"Student name is{name} and city is {city}");

        }
    }
}