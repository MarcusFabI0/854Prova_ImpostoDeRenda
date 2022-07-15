namespace Prova_ImpostoDeRenda.Presentation
{
    public interface ICanvas
    {
        void WelcomeMsg();
        string InformName();
        double InformSalary();
        void UserInstance();

        string GetCpf();
        void MoneyMsg();
        void PrintClientInfo();
    }
}