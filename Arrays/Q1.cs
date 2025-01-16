using System;
using System.Data;

namespace Arrays
{
    public class Q1
    {
        public static int SegundoMenor(int[] array)
        {
            int segundoMenor = 0;
            array = OrdenaArray.Ordenar(array);
            foreach(int i in array)
            {
                if (i > array[0])
                {
                    segundoMenor = i;
                    break;
                }                    
            }
            return segundoMenor;
        }
    }
}
