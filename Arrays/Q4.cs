using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Q4
    {
        public static string Ordenar(int[] array)
        {
            string arrayExibicao = string.Join(",", OrdenaArray.Ordenar(array));
            return "{" + arrayExibicao + "}";
        }
    }
}
