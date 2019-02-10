using System;

namespace Skolprojekt_spelregister
{
    class Program
    {
        static void Main(string[] args)
        {   /*         
            Console.WriteLine("[1] Registrera spel");
            Console.WriteLine("----------------------");
            Console.WriteLine("[2] Sök efter spel");
            Console.WriteLine("----------------------");
            Console.WriteLine("[3] Ta bort spel");
            Console.WriteLine("----------------------");
            Console.WriteLine("[4] Visa spelbibliotek");
            Console.WriteLine("----------------------");
            Console.WriteLine("[5] Avsluta");
            int menyVal = ReadInt();

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
                Console.WriteLine("Oj! här blev det lite fel, försök att ange en siffra mellan 1-5");
                Console.WriteLine("1. Registrera spel");
                Console.WriteLine("----------------------");
                Console.WriteLine("2. Sök efter spel");
                Console.WriteLine("----------------------");
                Console.WriteLine("3. Ta bort spel");
                Console.WriteLine("----------------------");
                Console.WriteLine("4. Visa spelbibliotek");
                Console.WriteLine("----------------------");
                Console.WriteLine("5. Avsluta");
                menyVal = ReadInt();
            }    
            */

            while (true)
            {
                Console.WriteLine("[1] Registrera spel");
                Console.WriteLine("----------------------");
                Console.WriteLine("[2] Sök efter spel");
                Console.WriteLine("----------------------");
                Console.WriteLine("[3] Ta bort spel");
                Console.WriteLine("----------------------");
                Console.WriteLine("[4] Visa spelbibliotek");
                Console.WriteLine("----------------------");
                Console.WriteLine("[5] Avsluta");
                int menyVal = ReadInt();

                if (menyVal == 1)
                {
                    RegSpel();
                }
                else if (menyVal == 2)
                {
                    SökSpel();
                }
                else if (menyVal == 3)
                {
                    TaBortSpel();
                }
                else if (menyVal == 4)
                {
                    SpelBibliotek();
                }
                else if (menyVal == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Oj! här blev det lite fel, försök att ange en siffra mellan 1-5");
                }
                
            }
        }
        public static void RegSpel()
        {
            Console.WriteLine("lägg kod för registrera spel här");
            string svar = Console.ReadLine();
        
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
        public static int ReadInt()
        {

            int d = 0;

            while (!int.TryParse(Console.ReadLine(), out d))
            {
                Console.Write("Måste vara ett numeriskt värde\nFörsök igen: ");

            }
            return d;
        }
    }
}
