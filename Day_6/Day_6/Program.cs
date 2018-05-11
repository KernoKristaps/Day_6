using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Ievadiet skaitli:");
            string ievads = Console.ReadLine();
            Console.WriteLine(PievienoSkaitli(ievads)); // pirmais variants bez vēl viena mainīgā

            string izvade = PievienoSkaitli(ievads); // otrs variants ar 2 mainīgajiem
            Console.WriteLine(izvade);

            int skaits = izvade.Length; // simbolu daudzumu aprēķina un izvada
            Console.WriteLine(skaits);
            Console.ReadLine();

            Console.WriteLine("Ievadi pirmo skaitli");
            string ievade1 = Console.ReadLine();
            double skaitlis1 = Convert.ToDouble(ievade1);

            Console.WriteLine("Ievadiet otro skaitli");
            ievade1 = Console.ReadLine();
            double skaitlis2 = Convert.ToDouble(ievade1);

            double izvade = SkaitluSalidzinasana(skaitlis1, skaitlis2);
            Console.WriteLine("Lielakais skaitlis ir " + izvade);*/



            for (int i = 0; i < 6; i = i + 2) // i++ ir i=i+1
            {
                i--;
                Console.WriteLine(i);
            }

            /*int skaititajs = 0;
            while (skaititajs != 5)
            {
                Console.WriteLine(skaititajs);
                skaititajs++;
            }*/


            Console.ReadLine();

        }
        

        static string PievienoSkaitli(string skaitlis)
        {
            string rezultats = "Mans skaitlis ir " + skaitlis;
            return rezultats;
        }

        static double SkaitluSalidzinasana(double skaitlis1, double skaitlis2)
        {
            double rezultats;
            if(skaitlis1 < skaitlis2)
            {
                rezultats = skaitlis2;
               // return rezultats; zem visiem if, lai izpildītu funkciju ātrāk
            }
            else
            {
                if(skaitlis2 < skaitlis1)
                {
                    rezultats = skaitlis1;
                    // return rezultats
                }
                else
                {
                    rezultats = 0;
                    Console.WriteLine("Kluda! Rezultats ir vienads!");
                    // return rezultats
                }
            }
            

            return rezultats;

        }




    }


}
