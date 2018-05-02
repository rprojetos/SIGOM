using System;
namespace ProjectHerancaPolimorfismo
{
    public class Classe1 : Mensagem
    {
        private String c1;
        private String msgC1 = "Teste - Msg Privada - Classe1";
        public String msg2 = "Mensagem da Classe-1";

        public void printClasse1(String m1){
            printMensagem(m1);
        }
    }


}
