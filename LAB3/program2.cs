using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class program2
    {
        private int privateFieldA;
        public program2(int value)
        {
            this.privateFieldA = value;
        }
        public int GetPrivateFieldA()
        {
            return privateFieldA;
        }
    }
}