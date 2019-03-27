using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFY___Ivt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Jmena = {"Adámek", "Blažek", "Capušek", "Jindrák", "Kolář", "Pavlata", "Řeháček", "Šimák", "Veselý", "Zmastil"};
            string[] Predmety = { "Cj", "Aj", "M", "F", "TV", "Z", "D", "Př", "Hv", "Vv" };
            int[, ] Znamky = new int[Jmena.Length, Predmety.Length];
            float[] Prumer = new float[Predmety.Length];
            Random rnd = new Random();

            Console.Write("Jméno\t"); Console.Write("Předmet\t\t\t\t\t\t\t\t\t\t"); Console.Write("Průmer\t"); Console.Write("Výsledek");
            Console.WriteLine();
            Console.Write("\t");
            for(int i = 0; i < Predmety.Length; i++)
            {
                Console.Write(Predmety[i] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < Jmena.Length; i++)
            {
                float mezi = 0;

                Console.Write(Jmena[i] + "\t");
                for(int c = 0; c < Predmety.Length; c++)
                {
                    Znamky[i, c] = rnd.Next(1, 6);
                    mezi = mezi + Znamky[i, c];
                    Console.Write(Znamky[i, c] + "\t");
                }
                Prumer[i] = mezi / Predmety.Length;
                Console.Write(Prumer[i] + "\t");

                if (Znamky[i, 0] == 5 || Znamky[i, 1] == 5 || Znamky[i, 2] == 5 || Znamky[i, 3] == 5 || Znamky[i, 4] == 5 || Znamky[i, 5] == 5 || Znamky[i, 6] == 5 || Znamky[i, 7] == 5 || Znamky[i, 8] == 5 || Znamky[i, 9] == 5)
                {
                    Console.Write("Neprospěl");
                    Console.WriteLine();
                    continue;
                }
                if (Prumer[i] <= 1.5)
                {
                    Console.Write("Vyznamanání");
                }
                else if(Prumer[i] <= 2 && Prumer[i] > 1.5)
                {
                    Console.Write("Velmi dobrý");
                }
                else if(Prumer[i] > 2)
                {
                    Console.Write("Prospěl");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

