using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Greater g = new Greater();
            g.Method();
            for (int i = 10; i <= 20; i = i + 1)
            {
                Console.WriteLine("value of i:{0}", i);

            }
                Console.ReadLine();
            

        }
    }
}
