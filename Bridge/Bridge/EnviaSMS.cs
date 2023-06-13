using System;

namespace BridgePratica
{
    public class EnviaSMS : IDespachaMensagem
    {
        public void EnviaMensagem(string mensagem)
        {
            Console.WriteLine($"### SMS : {mensagem}");
        }
    }
}
