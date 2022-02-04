using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bib;
namespace consolee
{
    class Program
    {
        static void Main(string[] args)
        {
            Demineur g = new Demineur();
            DisplayGrid(g.Grid);
            Console.ReadKey();
        }

        private static void DisplayGrid(int[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)

            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 9)
                    {
                        Console.Write($"  * |");
                    }
                    else
                    {
                        Console.Write($"{grid[i, j],3} |");
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
