using System;
using Gtk;
namespace sigom
{
    public class Mensagem
    {
        private String m;

        private void showMessage(String msg)
        {
            MessageDialog md = new MessageDialog(null,
            DialogFlags.DestroyWithParent, MessageType.Info,
            ButtonsType.Close, msg);
            md.Run();
            md.Destroy();
        }

        public void printMensagem(String mensagem)
        {
            m = mensagem;
            showMessage(m);
        }
    }
}
