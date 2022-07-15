using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ImpostoDeRenda.Domain.Data
{
    public class UserData
    {
        public string Name { get; set; }

        public SalaryData UserSalary { get; set; }

        public string CPF { get; set; }

        public UserData(string _name, SalaryData _userSalary, string cPF)
        {
            Name = _name;
            UserSalary = _userSalary;
            CPF = cPF;
        }

    }
}
