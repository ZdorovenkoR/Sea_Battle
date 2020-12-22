using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
             string[,] seaBattle =
            {
                { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
                { "O", "X", "X", "X", "X", "O", "X", "X", "O", "O" },
                { "O", "O", "O", "O", "O", "X", "O", "O", "O", "O" },
                { "O", "X", "X", "X", "O", "O", "X", "O", "X", "O" },
                { "O", "O", "O", "O", "X", "O", "X", "O", "O", "O" },
                { "O", "X", "X", "X", "O", "X", "O", "X", "X", "O" },
                { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
                { "O", "O", "O", "X", "O", "O", "O", "O", "X", "O" },
                { "O", "X", "O", "X", "O", "O", "X", "O", "O", "O" },
                { "O", "O", "O", "O", "O", "O", "X", "O", "X", "O" },
                { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" }
            };
            int rows = seaBattle.GetUpperBound(0) + 1;
            int columns = seaBattle.Length / rows;
            for (int i=0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                        {
                        Console.Write($"{seaBattle[i, j]} \t");
                        }
                Console.WriteLine();
                }
        }
    }
}
