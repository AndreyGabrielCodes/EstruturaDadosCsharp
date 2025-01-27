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
            arvore.Insert(8);
            arvore.Insert(5);
            arvore.Insert(2);

            //Q1
            Console.WriteLine("Q1 - Encontre a altura de uma árvore binária");
            Console.WriteLine($"- Resposta: {Q1.Altura(arvore.Root)}");

            //Q2
            int kEsimo = 3;
            Console.WriteLine($"Q2 - Encontre o k-ésimo valor máximo em uma árvore binária de busca\n- Input: {kEsimo}");
            Console.WriteLine($"- Resposta: {Q2.KEsimoMaior(kEsimo, arvore)}");
            
            //Q3
            int distanciaK = 3;
            Console.WriteLine($"Q3 - Encontre nós a uma distância \"k\" da raiz\n- Input: {distanciaK}");
            //Console.WriteLine($"- Resposta: ");
            Q3.kEsimosNos(arvore, distanciaK);
        }
    }
}
