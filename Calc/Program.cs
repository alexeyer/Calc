using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            Console.WriteLine(math.Add(10, 20));
            Console.ReadLine();
        }
    }
}
