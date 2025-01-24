using System;
using System.Collections.Generic;

namespace Arvores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicialização de uma arvore com 15 valores aleatórios não repetidos
            BinaryTree<int> arvore = new BinaryTree<int>();
            arvore.Insert(6);
            arvore.Insert(1);
            arvore.Insert(3);
            arvore.Insert(7);
            arvore.Insert(9);
            arvore.Insert(5);
            arvore.Insert(2);
            arvore.Insert(10);
            Action<int> printTeste = value => Console.WriteLine(value);
            arvore.InOrderTraversal(printTeste);
        }

    }
}
