using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ImpostoDeRenda.Domain.Validators
{
    public static class SalaryValidation
    {
        public static bool ValidSalary(this string userInput)
        {
            double valorSalario = 0;
            if (!(double.TryParse(userInput, out valorSalario) || valorSalario > 0))
            {
                return false;
            }
           else
            {
                return true;
            }

        }
    }
}
