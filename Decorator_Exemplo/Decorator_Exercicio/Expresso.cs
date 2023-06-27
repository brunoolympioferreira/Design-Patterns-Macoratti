namespace Decorator_Exercicio;
public class Expresso : ICafe
{
    public string Descricao()
    {
        return "Café Expresso";
    }

    public decimal Preco()
    {
        return 5.00M;
    }
}
