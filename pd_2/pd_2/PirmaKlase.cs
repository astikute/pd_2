using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_2
{
    class PirmaKlase
    {
       
        public double Reizinajums (double a, double b)
        {
            return a * b;
        }

        public double Dalijums (double a, double b)
        {
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
