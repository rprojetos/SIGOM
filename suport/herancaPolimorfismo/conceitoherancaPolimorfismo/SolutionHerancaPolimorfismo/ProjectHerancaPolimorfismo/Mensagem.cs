using System;
using Gtk;

namespace ProjectHerancaPolimorfismo
{
    public class Mensagem
    {
        private String m;
        private String msg0 = "Teste - Msg Privada";
        public String msg1 = "Mensagem da Classe-Mensagem";
        public String msg2 = "Teste - Mensagem da Classe-Mensagem";

        //public String codigo { get; private set; }

        public int codigo { get; set; }
        public String nome { get; set; }
        public String endereco { get; set; }
        public String telefone { get; set; }

        private void showMessage(String msg)
        {
            MessageDialog md = new MessageDialog(null,
            DialogFlags.DestroyWithParent, MessageType.Info,
            ButtonsType.Close, msg);
            md.Run();
            md.Destroy();
        }

        public void printDados()
        {
            showMessage("Código: " + codigo);
            showMessage("Nome: " + nome);
            showMessage("Endereço: " + endereco);
            showMessage("Telefone: " + telefone);
        }

        public void printMensagem(String mensagem)
        {
            m = mensagem;
            showMessage(m);
        }
    }
}
