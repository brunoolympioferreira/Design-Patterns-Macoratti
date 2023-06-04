namespace SemInterface;
public class RegistraOcorrencia
{
    public void RegistrarNoConsole(string mensagem)
    {
        Console.WriteLine($" {mensagem} : {DateTime.Now}");
    }

    public void RegistrarNoArquivo(string caminho)
    {
        //codigo para registrar no arquivo
    }

    public void RegistrarNoDatabase(string conexao, string mensagem)
    {
        //codigo para registrar no database
    }
}
