namespace Composite_Exercicio;

//component
public abstract class ItemQuestionario
{
    protected string Descricao;
    public ItemQuestionario(string descricao)
    {
        Descricao = descricao;
    }
    public abstract void Exibir();
}
