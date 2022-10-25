using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3haftaödevUygulama3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2,sonuc;
            Console.Write("Birinci Sayıyı girin:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı girin:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
           

            if (sayi1>sayi2)
            {
                if (sayi1 % sayi2 == 0)
                {
                    Console.Write("Sayi1 Sayi2'ye tam bölünmektedir.");
                    sonuc=sayi1 / sayi2;
                    Console.Write(sonuc);

                }
                else
                {
                    Console.Write("Bu sayılar birbirine bölünememektedir.");

                }
            }
            else
            {
                if(sayi2 % sayi1==0)
                {
                    Console.Write("Sayi2 sayi1'e tam bölünmektedir.");
                    sonuc = sayi2 / sayi1;
                    Console.WriteLine(sonuc);
                }
                else
                {
                    Console.Write("Bu sayılar birbirine tam bölünememektedir.");
                }
            }
            Console.ReadKey();
        }
    }
}
