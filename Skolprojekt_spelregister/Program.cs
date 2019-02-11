using System;
using System.Collections.Generic;

namespace Skolprojekt_spelregister
{
    class Program
    {

        public static List<Spel> spel = new List<Spel>();
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
                Console.Write("Välj från menyn (1-5): ");
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
            Console.Write("Är du säker?(Ja/Nej): ");
            string svar = Console.ReadLine();
            while(svar.Contains("ja") || svar.Contains("Ja"))
            {
                Console.Clear();
                Console.Write("Ange titel: ");
                string titel = Console.ReadLine();
                if(titel[titel.Length-1]== ' ')
                {
                    titel = titel.TrimEnd(' ');
                }
                titel = char.ToUpper(titel[0]) + titel.Substring(1);
                Console.Write("Ange genre: ");
                string genre = Console.ReadLine();
                if (genre[genre.Length - 1] == ' ')
                {
                    genre = genre.TrimEnd(' ');
                }
                genre = char.ToUpper(genre[0]) + genre.Substring(1);
                Console.Write("Ange betyg: ");
                string betygLine = Console.ReadLine();
                double betyg;
                while(!double.TryParse(betygLine,out betyg))
                {
                    Console.WriteLine("{0} är inte numerisk värde. OBS använd komma (,) och inte punkt (.) för värden med decimaler", betygLine);
                    Console.Write("Ange betyg: ");
                    betygLine = Console.ReadLine();
                }

                spel.Add(new Spel(titel, genre, betyg));
                Console.Write("Lägga till mer spel? (Ja/Nej): ");
                svar = Console.ReadLine();
            }
            Console.Clear();
        
        }
        public static void SökSpel()
        {
            string svar;

            do
            {
                Console.Clear();
                Console.Write("Ange titel/genre:");
                string sokT = Console.ReadLine();
                sokT = char.ToUpper(sokT[0]) + sokT.Substring(1);
                string sokG = sokT;
                
                List<Spel> result = spel.FindAll(x => x.Titel.Contains(sokT));
                List<Spel> resultG = spel.FindAll(y => y.Genre == sokG);
                if (result.Count != 0)
                {
                    Console.WriteLine("-----Hittade Spel-------");
                    foreach(Spel y in result)
                    {
                        Console.WriteLine("Titel: " + y.Titel + "\nGenre: " + y.Genre + "\nBetyg: " + y.Betyg);
                        Console.WriteLine("------------------------");
                    }
                    
                    Console.WriteLine();
                }
                if (resultG.Count != 0)
                {
                    Console.WriteLine("------Hittade Spel-------");
                    foreach (Spel spel in resultG)
                    {
                        Console.WriteLine("Titel: " + spel.Titel + "\nGenre: " + spel.Genre + "\nBetyg: " + spel.Betyg);
                        Console.WriteLine("------------------------");
                    }
                    Console.WriteLine();

                }
                Console.WriteLine("Ny sökning? (Ja/Nej)");
                svar = Console.ReadLine();
            } while (svar == "ja" || svar == "Ja"|| svar == "j" || svar == "J");
            Console.Clear();
        }
        public static void TaBortSpel()
        {
            string svar;
            if(spel.Count != 0)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("------ Alla spel -------");
                    int i = 1;
                    foreach (Spel s in spel)
                    {
                        Console.WriteLine(i + ". Titel: " + s.Titel);
                        Console.WriteLine("------------------------");
                        i++;
                    }
                    if(spel.Count == 1)
                        Console.WriteLine("Skriv exit för huvudmeny. Välj titel (1) för att radera: ");
                    else
                     Console.Write("Skriv exit för huvudmeny. Välj titel (1 - " + spel.Count + ") för att radera: ");
                    string deleteString = Console.ReadLine();
                    if (int.TryParse(deleteString, out int delete))
                    {
                        while (delete < 1 || delete > spel.Count)
                        {
                            Console.WriteLine("Fel val! Välj titel (1 - " + spel.Count + "): ");
                            deleteString = Console.ReadLine();
                            if (!int.TryParse(deleteString, out delete)) break;
                        }
                        spel.RemoveAt(delete - 1);
                        Console.Clear();
                        i = 1;
                        foreach (Spel s in spel)
                        {
                            Console.WriteLine(i + ". Titel: " + s.Titel);
                            Console.WriteLine("------------------------");
                            i++;
                        }
                        if(spel.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Radera ytterligare spel? (Ja/Nej): ");
                            svar = Console.ReadLine();
                        }
                        

                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }


                } while (svar == "ja" || svar == "Ja" || svar == "j" || svar == "J");
            }
           

        }
        public static void SpelBibliotek()
        {
            Console.Clear();
            Console.WriteLine("------ Alla spel -------");
            foreach(Spel s in spel)
            {
                Console.WriteLine("Titel: " + s.Titel + "\nGenre: " + s.Genre + "\nBetyg: " + s.Betyg);
                Console.WriteLine("------------------------");
            }
            Console.Write("Tryck enter för huvud meny...");
            Console.ReadLine();
            Console.Clear();
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
