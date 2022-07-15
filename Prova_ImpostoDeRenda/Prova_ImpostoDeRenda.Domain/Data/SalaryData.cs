using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ImpostoDeRenda.Domain.Data
{
    public class SalaryData
    {
        public double MonthSalary { get; set; }
        public double YearSalary { get; set; }

        public SalaryData(double _monthSalary, double _yearSalary)
        {
            MonthSalary = _monthSalary;
            YearSalary = _yearSalary;
        }

        public SalaryData(double _monthSalary)
        {
            MonthSalary = _monthSalary;
        }
    }
}
