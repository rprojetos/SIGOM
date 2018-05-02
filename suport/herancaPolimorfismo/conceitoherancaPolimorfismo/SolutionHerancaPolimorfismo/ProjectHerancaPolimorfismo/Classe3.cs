using System;
namespace ProjectHerancaPolimorfismo
{
    public class Classe3
    {
        public void CadastraCliente(int inCodigo, String inNome, 
                                    String inEndereco, String inTelefone)
        {
            Classe2 c2 = new Classe2();
            c2.codigo = inCodigo;
            c2.nome = inNome;
            c2.endereco = inEndereco;
            c2.telefone = inTelefone;
            c2.printDados();

            c2.printMensagem("msg1: " + c2.msg1);
            c2.printMensagem("msg2: " + c2.msg2);
            c2.printMensagem("msg3: " + c2.msg3);

        }
    }
}
