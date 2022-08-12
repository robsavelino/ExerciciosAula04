using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Print
    {
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(i == array.Length -1)
                    Console.WriteLine($"{array[i]}");
                
                else
                    Console.Write($"{array[i]}, ");
            }
        }
    }
}
