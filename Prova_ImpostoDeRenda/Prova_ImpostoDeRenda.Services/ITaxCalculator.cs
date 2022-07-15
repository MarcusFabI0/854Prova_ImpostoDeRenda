using Prova_ImpostoDeRenda.Domain.Data;

namespace Prova_ImpostoDeRenda.Services
    

{
    public interface ITaxCalculator
    {
        double TaxCalculation(SalaryData value);
        double Aliquot(double value);
        double Deduction(double value);

    }
}