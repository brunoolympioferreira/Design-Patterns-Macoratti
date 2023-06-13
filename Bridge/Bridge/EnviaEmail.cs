using System;

namespace BridgePratica
{
    public class EnviaEmail : IDespachaMensagem
    {
        public void EnviaMensagem(string mensagem)
        {
            Console.WriteLine($"### Email : {mensagem}");
        }
    }
}
