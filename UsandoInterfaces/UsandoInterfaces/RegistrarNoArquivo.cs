namespace UsandoInterfaces;
public class RegistrarNoArquivo : IRegistro
{
    private readonly string _caminhoNomeArquivo;
    public RegistrarNoArquivo(string path)
    {
        _caminhoNomeArquivo = path;
    }
    public void RegistraInfo(string mensagem)
    {
        Log(mensagem);
    }

    private void Log(string mensagem)
    {
        using var streamWriter = new StreamWriter(_caminhoNomeArquivo, true);
        streamWriter.WriteLine(mensagem);
    }
}
