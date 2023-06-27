namespace Decorator_Exercicio;
public class Capuccino : ICafe
{
    public string Descricao()
    {
        return "Capuccino";
    }

    public decimal Preco()
    {
        return 5.00M;
    }
}
