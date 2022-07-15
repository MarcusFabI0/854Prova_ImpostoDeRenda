using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova_ImpostoDeRenda.Domain.Data;
using Prova_ImpostoDeRenda.Domain.Validators;
using Prova_ImpostoDeRenda.Presentation;
using Prova_ImpostoDeRenda.Services;


namespace Prova_ImpostoDeRenda
{
    public class Program
    { 
        static void Main()
        {
            Canvas presentation = new();
            presentation.WelcomeMsg();
            presentation.InformName();
            Console.Clear();
            presentation.GetCpf();
            Console.Clear();
            presentation.InformSalary();
            Console.Clear();
            presentation.UserInstance();
            presentation.PrintClientInfo();
        }
    }
}