using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Validations
    {
        public static bool ValidateInput(string input)
        {
            if (!int.TryParse(input, out _) || Convert.ToInt32(input) > 3 || Convert.ToInt32(input) < 1)
            {
                Console.WriteLine("Invalid input, try again");
                return false;
            }
            return true;
        }

        public static bool ValidatePlay(string[,] matriz, int linha, int coluna)
        {
            if (matriz[linha, coluna] != null)
            {
                Console.WriteLine("Jogada invalida, tente novamente");
                return false;
            }
            return true;
        }

        public static bool GameEnd (string[,] matriz)
        {
            if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] && matriz[0, 0] != null)
                return true;
            if (matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] && matriz[1, 0] != null)
                return true;
            if (matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2] && matriz[2, 0] != null)
                return true;
            if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] && matriz[0, 0] != null)
                return true;
            if (matriz[0, 1] == matriz[1, 1] && matriz[1, 0] == matriz[2, 1] && matriz[0, 1] != null)
                return true;
            if (matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2] && matriz[0, 2] != null)
                return true;
            if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] && matriz[0, 0] != null)
                return true;
            if (matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0] && matriz[0, 02] != null)
                return true;

            return false;
        }
    }
}
