using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova_ImpostoDeRenda.Domain.Data;
using Prova_ImpostoDeRenda.Domain.Validators;



namespace Prova_ImpostoDeRenda.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public double TaxCalculation(SalaryData monthSalary)
        {
            double salary = (monthSalary.MonthSalary) * 12;
            return (salary * Aliquot(salary)) - Deduction(salary);
        }

        public double Aliquot(double value)
        {
            switch (value)
            {
                case >= 22847.77 and <= 33919.80:
                    return 0.075;

                case >= 33919.81 and <= 45012.60:
                    return 0.150;

                case >= 45012.61 and <= 55976.16:
                    return 0.225;

                case > 55976.17:
                    return 0.275;

                default: return 0;

            }
        }

        public double Deduction(double value)
        {
            switch (value)
            {
                case >= 22847.77 and <= 33919.80:
                    return 1713.58;

                case >= 33919.81 and <= 45012.60:
                    return 4257.57;

                case >= 45012.61 and <= 55976.16:
                    return 7633.51;

                case > 55976.17:
                    return 10432.32;
                    ;

                default: return 0;

            }
        }

        public TaxCalculator(SalaryData monthSalary)
        {

        }


    }
}
