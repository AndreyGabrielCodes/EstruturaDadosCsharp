using System;
using System.Data;

namespace Arrays
{
    public class Q1
    {
        public static int SegundoMenor(int[] array)
        {
            int segundoMenor = 0;
            array = OrdenaArray(array);
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

        private static int[] OrdenaArray(int[] array)
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
            return array;
        }
    }
}
