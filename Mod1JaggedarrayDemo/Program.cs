using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1JaggedarrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jagged Array Demo");
            int[][] temp = new int[4][]; // the first array must have a number or value 
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine($"Enter the number of readings for City{i}");
                int readinges=int.Parse(Console.ReadLine());
                temp[i]= new int[readinges]; // this locating size for the horizontal array.
                Console.WriteLine($" Enter {readinges} for City {i}");
                for (int j = 0; j < readinges; j++)
                {
                    Console.Write($"temp of City[{i}][{j}]: ");
                    temp[i][j] = int.Parse(Console.ReadLine()); // get the temp 
                }
            }
            Console.WriteLine("\nDisplating reading: ");
            for (int i = 0;i < temp.Length; i++)
            {
                Console.Write($"City {i} : ");
                for (int j = 0;j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j] + "F\t ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
