using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] tomb = new int[15];

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = random.Next(1, 101); 
                Console.Write(tomb[i] + ", ");
            }
            Console.ReadKey();
        }
    }
 }
