
class Cliente 
{
    public string nome;
    public Cliente(string nome, int idade)
    {
        this.nome = nome;
    }

    public void Saudacao()
    {
        Console.WriteLine(" - Olá, meu nomé è: " + nome);
    }
}

