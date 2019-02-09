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
            int menyVal;
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


            bool val = int.TryParse(Console.ReadLine(), out menyVal);
            if (val == false)
            {
                Console.WriteLine("Oj! här blev det fel, försök att ange en siffra mellan 1-5");
                
            }
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

                 val = int.TryParse(Console.ReadLine(), out menyVal);
                if (val == false)
                {
                    Console.WriteLine("Oj! här blev det fel, försök att ange en siffra mellan 1-5");

                }
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
