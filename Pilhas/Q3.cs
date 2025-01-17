using System.Collections.Generic;
using System.Data;

namespace Pilhas
{
    public class Q3
    {
        public static bool ValidacaoBalanceamento(string expressao)
        {
            Stack<char> parentesesEsquerdos = new Stack<char>();

            foreach (char caracter in expressao)
            {
                if (caracter == '(')
                {
                    parentesesEsquerdos.Push('(');
                }
                else if (caracter == ')') 
                {
                    if (parentesesEsquerdos.Count == 0)
                    {
                        return false;
                    }
                    parentesesEsquerdos.Pop();
                }
            }
            return parentesesEsquerdos.Count == 0;
        }
    }
}
