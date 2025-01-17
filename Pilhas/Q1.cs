using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas
{
    internal class Q1
    {
        public static double SeparaCaracteres(string expressao)
        {
            Stack<int> numeros = new Stack<int>();
            float resultado = 0;
            foreach (char i in expressao)
            {
                string caracter = i.ToString();
                if (caracter != " ")
                {
                    if (caracter != "+" && caracter != "-" && caracter != "*" && caracter != "/")
                    {
                        numeros.Push(Convert.ToInt32(caracter));
                    }
                    else
                    {
                        resultado = RealizaOperacao(numeros, caracter);
                        numeros.Push(Convert.ToInt32(resultado));
                    }
                }
            }
            return resultado;
        }

        private static float RealizaOperacao(Stack<int> stack, string operador)
        {
            float[] valores = new float[2];
            for (int i = 0; i < 2; i++)
            {
                valores[i] = stack.Pop();
            }
            float resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = valores[1] + valores[0];
                    break;
                case "-":
                    resultado = valores[1] - valores[0];
                    break;
                case "*":
                    resultado = valores[1] * valores[0];
                    break;
                case "/":
                    resultado = valores[1] / valores[0];
                    break;
            }            
            return resultado;
        }
    }
}
