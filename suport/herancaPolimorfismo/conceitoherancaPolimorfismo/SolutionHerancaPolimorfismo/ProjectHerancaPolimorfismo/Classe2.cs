using System;
namespace ProjectHerancaPolimorfismo
{
    public class Classe2 : Classe1
    {
        private String c2;
        private String msgC2 = "Teste - Msg Privada - Classe2";
        public String msg3 = "Mensagem da Classe-2";

        public void printClasse2(String m2)
        {
            printMensagem(m2);
        }

    }
}
