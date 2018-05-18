using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_2
{
    class OtraKlase
    {
        public void TrijPerim()
        {
            double P, a = 0, b = 0, c = 0;

            Console.WriteLine("Ievadiet trijstūra malu garumus: ");
            Console.Write("1) ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("2) ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("3) ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
            {
                P = a + b + c;
                Console.WriteLine("Trijstūra perimetrs = {0}", P);
            }
            else
            {
                Console.WriteLine("Kļūda! Pie perimetra netiksi.");
            }
        }

        public void MasivsAprekiniem()
        {
            string[] Masivs = new string[3];
            double a, b;

            Console.WriteLine("Ievadiet izteiksmi!");

            for (int i = 0; i < 3; i++)
            {
                Masivs[i] = Console.ReadLine();
            }

            a = Convert.ToDouble(Masivs[0]);
            b = Convert.ToDouble(Masivs[2]);

            if (Masivs[1] == "+")
            {
                Console.WriteLine ("Summa: {0}", a + b);
            }

            else if (Masivs[1] == "-")
            {
                Console.WriteLine("Starpība: {0}", a - b);
            }
            else
            {
                Console.WriteLine("Nav pieejama šāda darbība!");
            }
        }
    }
}
