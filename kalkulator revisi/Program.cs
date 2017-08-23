using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace kalkulator_revisi
{
    class Program
    {
        static double Pembagian(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            else
                return x / y;

        }

        static double Perkalian(double x, double y)
        {
            return x * y;
        }

        static double Penambahan(double x, double y)
        {
            return x + y;
        }

        static double Pengurangan(double x, double y)
        {
            return x - y;
        }

        static void info()
        {
            Console.WriteLine("\nTekan \"ESC \" untuk berhenti, atau tekan tombol lain untuk melanjutkan");
        }

        static void Main()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            //while (cki.Key != ConsoleKey.Escape)
            {
                Console.Write("Masukan angka ");
                double a = double.Parse(Console.ReadLine());
                if (a <= '0' && a >= '9')
                {
                    Console.ReadLine();
                }
                Thread.Sleep(1000);

                Console.Write("Masukan angka ");
                int b = int.Parse(Console.ReadLine());
                Thread.Sleep(2000);
                /*double total = Pembagian(a, b);
                       total = Perkalian(a, b);
                       total = Penambahan(a, b);
                       total = Pengurangan(a, b);*/
                Console.WriteLine("Hasil Pembagian      : " + Pembagian(a, b));
                Thread.Sleep(1000);
                Console.WriteLine("Hasil perkalian      : " + Perkalian(a, b));
                Thread.Sleep(1000);
                Console.WriteLine("Hasil Penambahan     : " + Penambahan(a, b));
                Thread.Sleep(1000);
                Console.WriteLine("Hasil Pengurangan    : " + Pengurangan(a, b));
                Thread.Sleep(1000);

            }
        }
    }
}