using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Print
    {
        public static void PrintArray(int[] array, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if(i == length - 1)
                    Console.Write($"{array[i]}.");
                else
                    Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
        }
    }
}
