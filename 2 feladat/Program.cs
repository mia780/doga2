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
            int[] tomb = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++) {
                tomb[i] = random.Next(50, 150);
            }
           
            double kicsi= 99999;
            double nagy = 0;
            
            Console.WriteLine("A tomb elemei:");
            foreach (int l in tomb)
            {
           
                Console.Write($"{l} ");
            }
            Console.WriteLine();
            
            for (int j = 0; j < tomb.Length; j++) 
            {
                if (tomb[j] < kicsi) {
                    kicsi = tomb[j];
                }
            }
            Console.WriteLine($"A legkisebb szám {kicsi}");
            
            for (int m = 0; m < tomb.Length; m++)
            {
                if (tomb[m] > nagy) {
                    nagy = tomb[m];
                }
            }
            Console.WriteLine($"A legnagyobb szám {nagy}");

            Array.Sort(tomb);
            Console.WriteLine($"A tomb csokkenő sorrendbe:");
            for (int r = tomb.Length - 1; r >= 0; r--)
            {
                Console.Write($"{tomb[r]} ");

            }
            
            
        }
    }
}
