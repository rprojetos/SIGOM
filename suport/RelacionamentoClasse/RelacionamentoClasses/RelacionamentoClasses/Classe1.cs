using System;
using System.Collections;

namespace RelacionamentoClasses
{
    public class Classe1
    {
        private String fc1 = "Frase da classe 1";

        private Classe2[] c2 = new Classe2[15];//

        private ArrayList alC2 = new ArrayList();

        Hashtable hashTable = new Hashtable();

        private Classe2 lc2;
        private Classe2 htc2;

        public Classe1()
        {
            c2[0].printC2();

            alC2.Add(lc2);
            alC2.Add(lc2);
            alC2.Add(lc2);
            alC2.Add(lc2);
            alC2.Add(lc2);
            alC2.Add(lc2);

            
        }

        public void printC1(){
            Console.WriteLine(fc1);

            alC2[0].;
        }
    }
}
