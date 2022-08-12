using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class GetInput
    {
        public static void GetArray(int[] array, int length)
        {
            string input;
            for (int i = 0; i < length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Digite {length} numeros inteiros");
                Console.WriteLine($"Digidando posicao {i + 1}");
                do
                {
                    input = Console.ReadLine().Trim();
                    if (Validations.ValidateInt(input))
                        array[i] = Convert.ToInt32(input);

                } while (!(int.TryParse(input, out _)));

            }
        }
        
        public static int GetLength()
        {
            string input;
            int length = 0;
            Console.WriteLine("Digite a quantidade de numeros do seu array");
            do
            {
                input = Console.ReadLine().Trim();
                if (Validations.ValidateInt(input))
                    length = Convert.ToInt32(input);

            } while (!int.TryParse(input, out _));
            return length;
        }
        
        public static void GetRank(int[] arrayAux, int[]array, Dictionary<int, int> numberRank, int[] arrayRank, int length)
        {
            int rank = 1;
            for (int i = length - 1; i >= 0; i--)
            {
                if (!numberRank.ContainsKey(arrayAux[i]))
                {
                    numberRank.Add(arrayAux[i], rank);
                    rank++;
                }
            }

            for (int i = 0; i < length; i++)
            {
                numberRank.TryGetValue(array[i], out arrayRank[i]);
            }
        }
    }
}
