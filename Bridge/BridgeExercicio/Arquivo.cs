using Bridge_Solucao;

namespace BridgeExercicio;
public abstract class Arquivo
{
    protected IGerarArquivo geraArquivo;
    public Arquivo(IGerarArquivo gerarArq)
    {
        geraArquivo = gerarArq;
    }

    public virtual void GravaArquivo(Funcionario funci)
    {
        geraArquivo.GeraArquivo(funci);
    }
}
