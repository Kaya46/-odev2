using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3haftauygulama4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tarih;

            string[] parcalar;

            Console.Write("gg.aa.yyyy formatında Tarihi Giriniz = ");

            tarih = Console.ReadLine();
             
            parcalar = tarih.Split('.');

            if (int.Parse(parcalar[1]) == 1) Console.WriteLine("Bulunduğumuz Ay Ocak");

            if (int.Parse(parcalar[1]) == 2) Console.WriteLine("Bulunduğumuz Ay Şubat");

            if (int.Parse(parcalar[1]) == 3) Console.WriteLine("Bulunduğumuz Ay Mart");

            if (int.Parse(parcalar[1]) == 4) Console.WriteLine("Bulunduğumuz Ay Nisan");

            if (int.Parse(parcalar[1]) == 5) Console.WriteLine("Bulunduğumuz Ay Mayıs");

            if (int.Parse(parcalar[1]) == 6) Console.WriteLine("Bulunduğumuz Ay Haziran");

            if (int.Parse(parcalar[1]) == 7) Console.WriteLine("Bulunduğumuz Ay Temmuz");

            if (int.Parse(parcalar[1]) == 8) Console.WriteLine("Bulunduğumuz Ay Ağustos");

            if (int.Parse(parcalar[1]) == 9) Console.WriteLine("Bulunduğumuz Ay Eylül");

            if (int.Parse(parcalar[1]) == 10) Console.WriteLine("Bulunduğumuz Ay Ekim");

            if (int.Parse(parcalar[1]) == 11) Console.WriteLine("Bulunduğumuz Ay Kasım");

            if (int.Parse(parcalar[1]) == 12) Console.WriteLine("Bulunduğumuz Ay Aralık");

            Console.ReadKey();


        }
    }
}
