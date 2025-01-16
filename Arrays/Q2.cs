using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Q2
    {
        public static string ExibePrimeirosInteiros(int[] array)
        {
            string arrayExibicao = string.Join(",", EncontraPrimeirosInteiros(array));
            return arrayExibicao;
        }
        public static List<int> EncontraPrimeirosInteiros(int[] array)
        {
            array = OrdenaArray.Ordenar(array);
            List<int> primeirosInteiros = new List<int>();
            int limitador = 5;
            int contador = 0;
            foreach (int i in array)
            {
                if (!InteiroDuplicado(array, i))
                {
                    primeirosInteiros.Add(i);
                    contador += 1;
                }
                if (contador == limitador)
                {
                    break;
                }
            }
            return primeirosInteiros;
        }

        private static bool InteiroDuplicado(int[] array, int numeroConsultado)
        {
            int nroAparecimentos = 0;
            foreach (int i in array)
            {
                if (i == numeroConsultado)
                {
                    nroAparecimentos += 1;
                }
            }
            bool inteiroDuplicado = false;
            if (nroAparecimentos > 1)
            {
                inteiroDuplicado = true;
            }
            return inteiroDuplicado;
        }
    }
}
