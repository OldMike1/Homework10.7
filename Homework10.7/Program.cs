using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._7
{
    class Program
    {
        static void Sum(int x)
        {
            int s = 0;
            for (int i = 1; i <= x; i++)
            {
                s += i;
            }
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sum(n);
        }
    }
}
