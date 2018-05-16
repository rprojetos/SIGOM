using System;
using System.Collections;
using System.Collections.Generic;

namespace sigom
{
    public class fifoService
    {
        public fifoService(List<String> numOs)
        {
            Queue q = new Queue();
            foreach (String iOs in numOs)
            {
                q.Enqueue(iOs); 
            } 

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}





/*
 * 
 * string[] nomes = { “André”, “Bruna”, “Carla”, “Daniel” };
 * 
 //Instanciando a classe que se encontra no namespace System.Collections
Queue q = new Queue();
//Adicionando 5 elementos na fila
q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);
q.Enqueue(4);
q.Enqueue(5);
Console.WriteLine("Exibindo ordem da fila:");
//Lê todos elementos e exibi e remover o primeiro
while (q.Count > 0)
{
Console.WriteLine(q.Dequeue());
}
//Exibe a quantidade de elementos restantes, ou seja, zero
Console.WriteLine("A lista agora possui " + q.Count.ToString() + " elementos.");
Console.Read();
 */