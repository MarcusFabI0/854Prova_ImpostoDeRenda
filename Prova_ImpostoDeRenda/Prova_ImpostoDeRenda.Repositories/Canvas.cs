using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova_ImpostoDeRenda.Domain.Validators;
using Prova_ImpostoDeRenda.Services;
using Prova_ImpostoDeRenda.Domain.Data;

namespace Prova_ImpostoDeRenda.Presentation
{
    public class Canvas : ICanvas
    {
        Guid idContrato { get; set; } = Guid.NewGuid();
        string Name { get; set; }
        double SalaryM { get; set; }
        double SalaryY { get; set; }
        string cpf { get; set; }
        double AliquotPerc { get; set; }
        double DeducExpense { get; set; } 
        double Money { get; set; }
        SalaryData salary { get; set; }
        UserData userData { get; set; }

        public Canvas()
        {

        }
        public Canvas(string _name, double _salaryM)
        {
            Name = _name;
            SalaryM = _salaryM;
        }
        public void WelcomeMsg()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("===============================================");
            Console.WriteLine("= Bem vindo a calculadora de imposto de renda!=");
            Console.WriteLine("===============================================");
            Console.ResetColor();
        }

        public string InformName()
        {
            Console.WriteLine("Por favor informe seu nome.");
            Console.Write("==>");
            string nameInput = Console.ReadLine();
            while (nameInput.EmptyInput())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Campo não pode estar em branco! Por favor preencha conforme solicitado.");
                Console.ResetColor();
                nameInput = Console.ReadLine();
            }
            Name = nameInput;
            return Name;
        }

        public double InformSalary()
        {
            Console.WriteLine($"{Name}, por favor digite seu salário mensal.");
            Console.Write("==> R$ ");
            string monthSalaryS = Console.ReadLine();
            monthSalaryS = monthSalaryS.Replace(".", ",");
            while (!monthSalaryS.ValidSalary())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido! Por favor tente novamente!");
                Console.Write("==>");
                Console.ResetColor();
                monthSalaryS = Console.ReadLine();
                monthSalaryS = monthSalaryS.Replace(".", ",");
            }
            SalaryM = double.Parse(monthSalaryS);
            SalaryY = SalaryM * 12;
            return SalaryM;

        }

        public string GetCpf()
        {   
            Console.WriteLine($"{Name}, por favor informe seu CPF.");
            Console.Write("==>");
            cpf = Console.ReadLine();
            while (!cpf.ValidCPF())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CPF inválido, por favor verifique e tente novamente!");
                Console.Write("==>");
                Console.ResetColor();
                cpf = Console.ReadLine();
            }
            this.cpf = cpf;
            return this.cpf;
        }

        public void UserInstance()
        {
            salary = new(SalaryM);

            userData = new(Name, salary, cpf);
        }

        public void MoneyMsg()
        {
            TaxCalculator tax = new(salary);
            Money = tax.TaxCalculation(salary);
            AliquotPerc = tax.Aliquot(SalaryY);
            DeducExpense = tax.Deduction(SalaryY);
            Console.WriteLine($"Alíquota:{AliquotPerc*100:F2}%");
            Console.WriteLine($"Despesa dedutível: {DeducExpense:C2}");
            Console.WriteLine($"==> Imposto a ser pago é de: {Money:C2}");

        }

        public void PrintClientInfo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=====================================================");
            Console.WriteLine("=========== CALCULADORA IMPOSTO DE RENDA ============");
            Console.WriteLine("========= Abaixo estão os dados solicitados =========");
            Console.WriteLine("=====================================================");
            Console.WriteLine($"{DateTime.Now}");
            Console.WriteLine($"Nº de protocolo da consulta: {idContrato}");
            Console.WriteLine($"Cliente: {userData.Name}");
            Console.WriteLine($"CPF: {Convert.ToUInt64(cpf):000\\.000\\.000\\-00} ");
            Console.WriteLine($"Renda Mensal: {SalaryM:C2}");
            Console.WriteLine($"Renda Anual: {SalaryM * 12:C2}");
            MoneyMsg();
            Console.WriteLine("=====================================================");
            Console.ResetColor();

        }
    }
}




