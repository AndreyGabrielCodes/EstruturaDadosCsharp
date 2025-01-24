namespace Arvores
{
    public class No
    {
        public int valor { get; set; }
        public No direita { get; set; }
        public No esquerda { get; set; }

        public No(int valor)
        {
            this.valor = valor;
            direita = null;
            esquerda = null;
        }
    }
}
