using Bridge_Solucao;

namespace BridgeExercicio;
public class GeraXML : IGerarArquivo
{
    public void GeraArquivo(Funcionario funci)
    {
        //Logica para gerar dados no formato XML
        Console.WriteLine($"Dados do funcionário: {funci.Nome} gerado no formato XML");
    }
}
