using System.Text;

namespace BridgePratica
{
    public class MensagemAnexo : Mensagem
    {
        public MensagemAnexo(IDespachaMensagem despachaMensagem)
        {
            this.despachaMensagem = despachaMensagem;
        }

        private string anexo = " <<[Anexo]>> ";
        public override void EnviaMensagem(string mensagem)
        {
            StringBuilder mensagemAnexo = new StringBuilder(mensagem);
            mensagemAnexo.Append(anexo);
            despachaMensagem.EnviaMensagem(mensagemAnexo.ToString());
        }
    }
}
