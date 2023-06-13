using Bridge_Solucao;

namespace BridgeExercicio;
public class CalculaSalario : Arquivo
{
    public CalculaSalario(IGerarArquivo gerarArquivo) : base(gerarArquivo)
    {

    }

    public void ProcessaSalarioFunci(Funcionario funci)
    {
        funci.SalarioTotal = funci.SalarioBase + funci.Incentivo;
        Console.WriteLine($"Valor do salário para o funcionário {funci.Nome} R$ {funci.SalarioTotal}");

        geraArquivo.GeraArquivo(funci);
    }
}
