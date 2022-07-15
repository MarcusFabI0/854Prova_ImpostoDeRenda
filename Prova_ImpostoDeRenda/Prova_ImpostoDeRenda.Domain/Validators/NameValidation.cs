using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ImpostoDeRenda.Domain.Validators
{
    public static class NameValidation
    {
        public static bool EmptyInput(this string userInput)
        {

            if (String.IsNullOrWhiteSpace(userInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

