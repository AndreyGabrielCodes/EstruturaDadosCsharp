using System.Collections.Generic;

namespace Filas
{
    public class Q3
    {
        public static string ExibeNumerosDecimaisGerados(int numeroMaximo)
        {
           // int[] nValores = InicializaValores(numeroMaximo);
            string exibicaoBinarios = string.Join(",", CalculaBinario(numeroMaximo));
            return exibicaoBinarios;
        }

        //calcula o números binário e inverte (com pilha) apenas os valores pares
        private static Queue<string> CalculaBinario(int numeroMaximo)
        {
            Queue<string> binariosCorretos = new Queue<string>();
            for (int valor = 1; valor < numeroMaximo; valor++)
            {
                Queue<int> binariosImpares = new Queue<int>();
                Stack<int> binariosPares = new Stack<int>();
                int valorDividido = valor;
                while (valorDividido != 0)
                {
                    int resto = valorDividido % 2;
                    valorDividido = valorDividido / 2;
                    if (valor % 2 == 0)
                    {
                        binariosPares.Push(resto);
                    }
                    else
                    {
                        binariosImpares.Enqueue(resto);
                    }
                }
                if (valor % 2 == 0)
                {
                    string numeroBinario = "";
                    foreach (int numero in binariosPares)
                    {
                        numeroBinario += numero;
                    }
                    binariosCorretos.Enqueue(numeroBinario);
                }
                else
                {
                    binariosCorretos.Enqueue(string.Join("", binariosImpares));
                }
            }
            return binariosCorretos;
        }
    }
}
