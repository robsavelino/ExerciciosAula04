using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Print
    {
        public static void PrintMatriz (int[,] matriz, int linha, int coluna)
        {
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"{matriz[i,j]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
