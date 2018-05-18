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

            PirmaKlase PK1 = new PirmaKlase();
            OtraKlase OK1 = new OtraKlase();

            Console.WriteLine("0. Iziet (ESC) \n1. Summa (+) \n2. Starpība (-) \n3. Rezininājums (*) \n4. Dalījums (/) \n5. Kāpinājums (^) \n6. Trijstūra perimetra aprēķināšana (TP) \n7. Aprēķins caur masīvu (AM) \n");

            while (izpilde == true)
            {
                Console.Write("Kādu darbību veiksim? ");
                lietotajaIzvele = Console.ReadLine();

                switch (lietotajaIzvele)
                {
                    case "ESC":
                        izpilde = false;
                        break;
                    case "+":
                        Console.WriteLine("Summa = {0}", PK1.Summa());
                        break;
                    case "-":
                        Console.WriteLine("Starpība = {0}", PK1.Starpiba());
                        break;
                    case "*":
                        Console.WriteLine("Reizinājums = {0}", PK1.Reizinajums());
                        break;
                    case "/":
                        Console.WriteLine("Dalījums = {0}", PK1.Dalijums());
                        break;
                    case "^":
                        Console.WriteLine("Kāpinājums = {0}", PK1.Kapinajums());
                        break;
                    case "TP":
                        OK1.TrijPerim();
                        break;
                    case "AM":
                        OK1.MasivsAprekiniem();
                        break;
                    default:
                        Console.WriteLine("Kaut ko izdarīji ne tā...");
                        break;
                }
            }
        }
    }
}