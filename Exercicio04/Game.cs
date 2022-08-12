using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Game
    {
        public static void Start()
        {
            Console.WriteLine("Jogo da velha");

            int linha = 0;
            int coluna = 0;
            string[,] matriz = new string[3, 3];

            bool end = false;
            int plays = 0;
            bool validPlay;

            while (!end && plays < 9)
            {
                Print.PrintBoard(matriz);
                validPlay = false;
                while (!validPlay)
                {
                    Console.WriteLine("Jogador 01, faca a sua jogada");
                    linha = GetInput.GetLinhas();
                    coluna = GetInput.GetColuna();
                    validPlay = Validations.ValidatePlay(matriz, linha - 1, coluna - 1);
                }
                matriz[linha - 1, coluna - 1] = "X";
                plays++;
                Console.Clear();
                Print.PrintBoard(matriz);

                if (Validations.GameEnd(matriz))
                {
                    Console.WriteLine("O jogador 01 venceu");
                    end = true;
                    continue;
                }
                validPlay = false;

                while (!validPlay)
                {
                    Console.WriteLine("Jogador 01, faca a sua jogada");
                    linha = GetInput.GetLinhas();
                    coluna = GetInput.GetColuna();
                    validPlay = Validations.ValidatePlay(matriz, linha - 1, coluna - 1);
                }
                plays++;
                matriz[linha - 1, coluna - 1] = "O";

                if (Validations.GameEnd(matriz))
                {
                    Console.WriteLine("O jogador 02 venceu");
                    end = true;
                    continue;
                }
                Console.Clear();

            }
        }
    }
}
