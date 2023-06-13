using Bridge_Solucao;
using BridgeExercicio;

Funcionario funci1 = new Funcionario
{
    Id = 101,
    Nome = "Macoratti",
    SalarioBase = 3000,
    Incentivo = 900
};

CalculaSalario calculaSalario = new CalculaSalario(new GeraXML());

calculaSalario.ProcessaSalarioFunci(funci1);

funci1.Incentivo = 1200;

calculaSalario = new CalculaSalario(new GeraJson());

calculaSalario.ProcessaSalarioFunci(funci1);

Console.ReadKey();
