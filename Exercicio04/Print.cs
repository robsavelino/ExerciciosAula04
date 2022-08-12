using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Print
    {
        public static void PrintBoard(string[,] matriz)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                        Console.Write($" {matriz[i,j]}");
                    else
                        Console.Write($" {matriz[i, j]}|");
                }
                Console.WriteLine();
                if(i < 2)
                    Console.WriteLine("_______________");
            }
        }

    }
}
