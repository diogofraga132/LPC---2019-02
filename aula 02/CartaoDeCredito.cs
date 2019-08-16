namespace aula_02
{
    public class CartaoDeCredito
    {
        public CartaoDeCredito(int numero, string dataValidade, Cliente cliente)
        {
            this.numero = numero;
            this.dataValidade= dataValidade;
            this.cliente = cliente;
        }
        public int numero { get; private set; }
        public string dataValidade { get; private set; }
        public Cliente cliente {get; set;}

    }
}