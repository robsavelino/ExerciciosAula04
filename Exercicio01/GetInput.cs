using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class GetInput
    {
        public static void GetArray (int[] array, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Digite {length} numeros inteiros");
                Console.WriteLine($"Digidando posicao {i + 1}");
                string input;
                do
                {
                    input = Console.ReadLine().Trim();
                    if (Validations.ValidateInt(input))
                        array[i] = Convert.ToInt32(input);

                } while (!(int.TryParse(input, out _)));

            }
        }
        public static (int, int) GetArrayOddEven(int[] array,int length,int[] arrayOdd, int[] arrayEven, int countOdd, int countEven)
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    arrayEven[countEven] = array[i];
                    countEven++;
                    continue;
                }
                arrayOdd[countOdd] = array[i];
                countOdd++;
            }
            return (countEven, countOdd);
        }
    }
}
