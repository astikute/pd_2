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

            Console.WriteLine("Ievadiet trijstura malu garumus: ");
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
                Console.WriteLine("Kļūda!");
            }
        }

        public void Masivs()
        {

        }
    }
}
