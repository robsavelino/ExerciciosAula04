using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class GetInput
    {
        public static int GetLinhas()
        {
            Console.WriteLine("Digite o numero de linhas");
            string input;
            do
            {
                input = Console.ReadLine();
                if (Validations.ValidateInt(input))
                    return Convert.ToInt32(input);

            } while (!int.TryParse(input, out _));

            return Convert.ToInt32(input);
        }
        public static int GetColunas()
        {
            Console.WriteLine("Digite o numero de colunas");
            string input;
            do
            {
                input = Console.ReadLine();
                if (Validations.ValidateInt(input))
                    return Convert.ToInt32(input);

            } while (!int.TryParse(input, out _));

            return Convert.ToInt32(input);
        }
        public static int GetNumber()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                if (Validations.ValidateInt(input))
                    return Convert.ToInt32(input);

            } while (!int.TryParse(input, out _));

            return Convert.ToInt32(input);
        }


        public static void GetMatriz(int[,] matriz, int linha, int coluna)
        {
            Console.WriteLine("Digite os valores da matriz: ");

            for(int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.WriteLine($"Linha {i + 1}, Coluna {j + 1}: ");
                    matriz[i,j] = GetNumber();
                    Console.Clear();
                }
            }
        }
    }
}
