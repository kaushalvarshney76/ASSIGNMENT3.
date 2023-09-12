using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment3
{
    internal class Program
    {
        private String My_name;
        public void setvalue(String name1)
        {
            My_name = name1;
        }
        public string getvalue()
        {
            return My_name;
        }
        static void Main(string[] args)
        {
            /*Program p1 = new Program();
               p1.setvalue("Amit");
               String name=p1.getvalue();
               Console.WriteLine(name);
               Console.ReadLine();*/

            /* program2 p2 = new program2(22);
             int value = p2.GetPrivateFieldA();
             Console.WriteLine(value);
             Console.ReadLine();*/

            //Child.Main(new String[] { });

            /*program4 p4 = new program4("AP Singh");
             p4.Getnames();
            Console.ReadLine();*/

            /*Dev d1 = new Dev();
            Console.WriteLine(d1.city);
            d1.print2();
            d1.GetUserInfo();
            Console.ReadLine();*/

            Child2.Main(new String[] { });

            //program7.Main(new String[] { });

            // program8 c8 = new program8("BHarat",987456);
            // c8.Getinfo2();

            //Dev1 d1 = new Dev1();
            //d1.Print3();

            // program10 c = new program10(10);
            //c.print();
        }

        internal class Dev : program5
        {
            public Dev() : base("Mohit", "Sirsaganj") { }
            internal void print2()
            {
                Console.WriteLine($"the Derived user name is {name} and city is {city} and is age  {age} and ac num is {account}");
            }
        }

    }
}