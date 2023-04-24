using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_5
{
    internal class Program
    {
        private static int test(int x)
        {
            double result;
            result = Math.Pow(x,2) + (2*x) - 4;
            Console.WriteLine(result);
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" x ra vared konin");
            int x = Convert.ToInt32(Console.ReadLine());
            test(x);
        }
    }
}
