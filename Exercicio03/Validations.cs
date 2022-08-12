﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Validations
    {
        public static bool ValidateInt(string input)
        {
            if (!int.TryParse(input, out _))
            {
                Console.WriteLine("Invalid input, try again");
                return false;
            }
            return true;
        }
    }
}
