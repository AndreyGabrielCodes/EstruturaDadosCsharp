using System;
using System.Collections.Generic;

namespace Pilhas
{
    public class Q2
    {
        public static string ExibePilhaOrdenada(Stack<int> stack)
        {
            string stackOrdenado = string.Join(",", OrdenaPilha(stack));
            return "{" + stackOrdenado + "}";
        }
        
        private static int[] OrdenaPilha(Stack<int> stack)
        {
            int[] array = new int[stack.Count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = stack.Pop();
            }
            int [] stackOrdenado = OrdenaArray(array);
            return stackOrdenado;
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
