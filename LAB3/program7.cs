using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class program7
    {
        private int sellery;
        private int ac_num;

        private program7(int sellery, int ac_num)
        {
            this.sellery = sellery;
            this.ac_num = ac_num;
        }

        public void Setvalue(int sellery, int ac_num)
        {
            this.sellery = sellery;
            this.ac_num = ac_num;
        }
        public void Getvalue()
        {

            Console.WriteLine($" Sellery is {sellery} and account number is {ac_num}");

        }
        internal static void Main(string[] args)
        {

            program7 c7 = new program7(1200, 12345);
            c7.Getvalue();
            c7.Setvalue(1000, 55555);
            c7.Getvalue();
            Console.ReadLine();
        }

    }
}