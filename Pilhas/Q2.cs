using System.Collections.Generic;

namespace Pilhas
{
    public class Q2
    {
        public static string ExibePilhaOrdenada(Stack<int> stack)
        {
            string stackOrdenado = string.Join(" ", OrdenaPilha(stack));
            return stackOrdenado;
        }
        
        private static Stack<int> OrdenaPilha(Stack<int> stack)
        {
            Stack<int> stackOrdenado = new Stack<int>();
            for (int i = 0; i < stack.Count; i++)
            {
                int[] valores = new int[2];
                valores[0] = stack.Pop();
                valores[1] = stack.Pop();

                if (valores[0] < valores[1])
                {
                    stackOrdenado.Push(valores[0]);
                    stackOrdenado.Push(valores[1]);
                }
                else
                {
                    stackOrdenado.Push(valores[1]);
                    stackOrdenado.Push(valores[0]);
                }
            }
            return stackOrdenado;
        }
    }
}
