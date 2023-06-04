namespace UsandoInterfaces;
public class RegistrarNoConsole : IRegistro
{
    public void RegistraInfo(string mensagem)
    {
        Console.WriteLine($"info: {mensagem}");
    }
}
