using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a tömb méretét");
            int n = int.Parse(Console.ReadLine());
            tomb (n) = random.Next(50, 150);
            Random random = new Random();
           
            double kicsi= 0;
            double nagy = 0;
            double csokkeno;
            int[] tomb = int.Parse(Console.ReadLine();

            

            for (int i = 0; i < tomb.Length i++)
            {
                
                Console.WriteLine($"A tömb elemei:{tomb[i]}"); 

            }
            foreach (int l in tomb)
            {
           
                tomb[l] = random.Next(50, 150);
                Console.WriteLine($"A tomb elemei:{l}");

            }
            for (int j = 0; j < tomb.Length; j++) 
            {
                tomb[i] = random.Next(50, 150);
                if (tomb[j] < kicsi) 
                kicsi = tomb[j];
                
                Console.WriteLine($"A legkisebb szám {kicsi}");
            }
            for (int m = 0; m < tomb.Length; m++)
            {
                tomb[m] = random.Next(50, 150);
                if (tomb[m] > nagy) 
                nagy = tomb[m];
                
                Console.WriteLine($"A legnagyobb szám {nagy}");
            }
            for (int r = 0; r < tomb.Length; r++)
            {
                if (tomb[r] > csokkeno) 
                    csokkeno.

                Console.WriteLine($"A tomb csokkenő sorrendbe: {csokkeno}");
            }
            
            
        }
    }
}
