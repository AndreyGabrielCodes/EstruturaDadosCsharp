using System.Collections.Generic;

namespace Pilhas
{
    public class Q2
    {
        public static void OrdenaPilha(Stack<int> stack)
        {
            Stack<int> stackOrdenado = new Stack<int>();
            foreach (int i in stack)
            {
                Stack<int> stackTemp = stack;
                stackTemp.Pop();
                foreach (int j in stackTemp)
                {
                    if (j < i)
                    {
                        stackOrdenado.Push(j);
                    }
                }
            }
        }
    }
}
