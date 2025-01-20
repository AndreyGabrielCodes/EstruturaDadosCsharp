using System;
using System.Collections.Generic;

namespace Filas
{
    public class Q3
    {
        public static string ExibeNumerosDecimaisGerados(int numeroMaximo)
        {
            int[] nValores = InicializaValores(numeroMaximo);
            CalculaBinario(nValores);
            string teste = "";
            return teste;
        }

        private static int[] InicializaValores(int numeroMaximo)
        {
            int[] nValores = new int[numeroMaximo];
            for (int i = 0, j = 1; i < numeroMaximo; i++, j++)
            {
                nValores[i] = j;
            }
            return nValores;
        }

        private static void CalculaBinario(int[] nValores)
        {
            Queue<int> numerosBinarios = new Queue<int>();
            Queue<int> temp = new Queue<int>();
            foreach (int valor in nValores)
            {
                if (valor == 1)
                {
                    numerosBinarios.Enqueue(valor);
                }
                else
                {
                    int contador = 0;
                    int valorTemp = valor;
                    while (valorTemp != 0)
                    {
                        int resto = valorTemp % 2;
                        valorTemp = valorTemp / 2;
                        temp.Enqueue(resto);
                        contador++;
                    }
                    InverteResultadoCalculo(temp, contador);
                }
            }
        }

        private static void InverteResultadoCalculo(Queue<int> temp, int contador)
        {
            for (int i = 1; i < contador; i++)
            {
                int valorAnterior = temp.Dequeue();
                temp.Enqueue(valorAnterior);
            }
            Console.WriteLine(string.Join("", temp));
            temp.Clear();
        }
    }
}
