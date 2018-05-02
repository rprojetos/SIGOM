using System;
namespace sigom
{
    public class Calculadora : Mensagem
    {
        private int n;

        private int Soma(int num1, int num2)
        {
            n = num1 + num2;
            return n;
        }

        public void Calcular(int op, int number1, int number2)
        {
            String res = "";
            switch (op)
            {
                case 1:
                    res = Soma(number1, number2).ToString();
                    break;
                default:
                    res = "Parâmetro operação 'op', incorreto";
                    break;
            }

            printMensagem(res);
        }
    }
}
