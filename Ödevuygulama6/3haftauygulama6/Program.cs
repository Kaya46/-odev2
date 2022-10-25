using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3haftauygulama6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d, r, g;
            double pi = 3.14;

            Console.Write("Açıyı giriniz = ");
            d = Convert.ToInt32(Console.ReadLine());

            r = Convert.ToInt32(d * pi / 180);
            g = d * 200 / 180;

            Console.Write("Radyan = " + r);
            Console.Write("\nGrad = " + g);
            Console.ReadKey();
        }
    }
}
