using System;
using System.Data;

namespace Arrays
{
    public class Q1
    {
        public static int RetornaSegundoMenor(int[] array)
        {
            int segundoMenor = 0;
            OrdenaArray(array);
            return segundoMenor;
        }

        private static void OrdenaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
