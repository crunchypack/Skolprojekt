using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolprojekt_spelregister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Registreraspel");
            Console.WriteLine("----------------------");
            Console.WriteLine("2. Sök efter spel");
            Console.WriteLine("----------------------");
            Console.WriteLine("3. Ta bort spel");
            Console.WriteLine("----------------------");
            Console.WriteLine("4. Visa spelbibliotek");
            Console.WriteLine("----------------------");
            Console.WriteLine("5. Avsluta");
            Console.WriteLine("----------------------");

            int menyVal = int.Parse(Console.ReadLine());

            while (menyVal != 5)
            {
                switch (menyVal)

                {
                    case 1:
                        RegSpel();
                    break;
                    case 2:
                        SökSpel();
                        break;
                    case 3:
                        TaBortSpel();
                        break;
                    case 4:
                        SpelBibliotek();
                        break;
                }
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Registrera spel");
                Console.WriteLine("----------------------");
                Console.WriteLine("2. Sök efter spel");
                Console.WriteLine("----------------------");
                Console.WriteLine("3. Ta bort spel");
                Console.WriteLine("----------------------");
                Console.WriteLine("4. Visa spelbibliotek");
                Console.WriteLine("----------------------");
                Console.WriteLine("5. Avsluta");
                Console.WriteLine("----------------------");

                menyVal = int.Parse(Console.ReadLine());

            }

           
        }
        public static void RegSpel()
        {
            Console.WriteLine("lägg kod för registrera spel här");
            string titel = Console.ReadLine();
            
        }
        public static void SökSpel()
        {
            Console.WriteLine("lägg kod för sök spel här");
            Console.ReadLine();
        }
        public static void TaBortSpel()
        {
            Console.WriteLine("lägg kod för Ta bort spel här");
            Console.ReadLine();
        }
        public static void SpelBibliotek()
        {
            Console.WriteLine("lägg kod för Visa spelbibliotek här");
            Console.ReadLine();
        }
    }
}
