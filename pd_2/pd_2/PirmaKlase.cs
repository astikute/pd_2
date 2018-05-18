using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_2
{
    class PirmaKlase
    {
        private double a, b;

        public void Get()
        {
            Console.Write("Ievadiet pirmo skaitli: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ievadiet otro skaitli: ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public double Summa()
        {
            Get();
            return a + b;
        }

        public double Starpiba()
        {
            Get();
            return a - b;
        }

        public double Reizinajums ()
        {
            Get();
            return a * b;
        }

        public double Dalijums ()
        {
            Get();
            return a / b;
        }

        public double Kapinajums ()
        {
            double b = 1;

            Console.Write("Ievadiet skaitli, ko kāpināt: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ievadiet pakāpi: ");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= c; i++)
            {
                b = b * a;
            }
            return b;
        }
    }
}
