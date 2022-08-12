using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class GetInput
    {
        public static int GetLinhas()
        {
            Console.WriteLine("Digite o numero da linha de 1 a 3");
            string input;
            do
            {
                input = Console.ReadLine();
                if (Validations.ValidateInput(input))
                    return Convert.ToInt32(input);

            } while (!int.TryParse(input, out _) || Convert.ToInt32(input) > 3 || Convert.ToInt32(input) < 1);

            return Convert.ToInt32(input);
        }
        public static int GetColuna()
        {
            Console.WriteLine("Digite o numero da coluna de 1 a 3");
            string input;
            do
            {
                input = Console.ReadLine();
                if (Validations.ValidateInput(input))
                    return Convert.ToInt32(input);

            } while (!int.TryParse(input, out _) || Convert.ToInt32(input) > 3 || Convert.ToInt32(input) < 1);

            return Convert.ToInt32(input);
        }
    }
}
