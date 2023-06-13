using Bridge_Solucao;

namespace BridgeExercicio;
public class GeraJson : IGerarArquivo
{
    public void GeraArquivo(Funcionario funci)
    {
        //logica para gerar os casos no formato JSON
        Console.WriteLine($"Dados do funcionário : {funci.Nome} gerados no formato JSON");
    }
}
