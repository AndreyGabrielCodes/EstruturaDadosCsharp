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
            Queue<int> temp = new Queue<int>();
            foreach (int valor in nValores)
            {
                if (valor == 1)
                {
                    temp.Enqueue(valor);
                }
                else
                {
                    int valorDividido = 0;
                    while (valorDividido != 1)
                    {

                        int resto = valor % 2;
                        valorDividido = valor / 2;
                        temp.Enqueue(resto);
                        Console.WriteLine(valorDividido);

                    }
                    Console.WriteLine("resto");
                }
            }
        }
    }
}
