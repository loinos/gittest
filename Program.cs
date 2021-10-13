using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace gittest
{
    class Program
    {
        public int sub(int x, int y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
        }

        public static decimal Multiplication(decimal a, decimal b)
        {
            return a * b;
        }
    }
}
