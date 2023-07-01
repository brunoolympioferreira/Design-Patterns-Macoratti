namespace Facade_Exercicio.Subsistema;
public class ServicoAClient
{
    public Livro PesquisaLivro(string isbn)
    {
        //definir instancia HttpClient
        //definir endereço base
        //definir formato de resposta JSON
        //montar o request GET]
        //tratar a resposta no formato JSON
        return ServicoA.GetLivro(isbn);
    }
}
