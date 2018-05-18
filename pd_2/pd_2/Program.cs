using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool izpilde = true;
            string lietotajaIzvele;
            string turpIzvele;
            double vertiba1 = 0, vertiba2 = 0;

            PirmaKlase PK1 = new PirmaKlase();
            OtraKlase OK1 = new OtraKlase();

            Console.WriteLine("1. Summa (+) \n2. Starpība (-) \n3. Rezininājums (*) \n4. Dalījums (/) \n5. Kāpinājums (^) \n6. Trijstūra perimetra aprēķināšana (TP) \n");

            while (izpilde == true)
            {
                Console.Write("Kādu darbību veiksim? ");
                lietotajaIzvele = Console.ReadLine();

                if (lietotajaIzvele != "^" && lietotajaIzvele != "TP")
                {
                    Console.Write("Ievadiet pirmo skaitli: ");
                    vertiba1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ievadiet otro skaitli: ");
                    vertiba2 = Convert.ToDouble(Console.ReadLine());
                }

                switch (lietotajaIzvele)
                {
                    case "+":
                        Console.WriteLine("Summa = {0}", Summa(vertiba1, vertiba2));
                        break;
                    case "-":
                        Console.WriteLine("Starpība = {0}", Starpiba(vertiba1, vertiba2));
                        break;
                    case "*":
                        Console.WriteLine("Reizinājums = {0}", PK1.Reizinajums(vertiba1, vertiba2));
                        break;
                    case "/":
                        Console.WriteLine("Dalījums = {0}", PK1.Dalijums(vertiba1, vertiba2));
                        break;
                    case "^":
                        Console.WriteLine("Kāpinājums = {0}", PK1.Kapinajums());
                        break;
                    case "TP":
                        OK1.TrijPerim();
                        break;
                    default:
                        Console.WriteLine("Kaut ko izdarīji ne tā...");
                        break;
                }

                Console.WriteLine("Vai turpināsim (Jā/Nē)?");
                turpIzvele = Console.ReadLine();
                if (turpIzvele == "Nē")
                {
                    izpilde = false;
                }
            }
        }

        static double Summa (double a, double b)
        {
            return a + b;
        }

        static double Starpiba (double a, double b)
        {
            return a - b;
        }
    }
}