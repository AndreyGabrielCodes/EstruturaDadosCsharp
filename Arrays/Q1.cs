using System;

namespace Arrays
{
    public class Q1
    {
        public static int RetornaSegundoMenor(int[] array)
        {
            int indiceMenor = array[0];
            int indiceSegundoMenor = 0;
            foreach (int i in array)
            {
                foreach (int indiceSeguinte in array)
                {
                    if (indiceSeguinte < indiceMenor)
                    {
                        indiceMenor = indiceSeguinte;
                    }
                }
            }
            return indiceMenor;
        }
    }
}
