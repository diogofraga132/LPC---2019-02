namespace aula_02
{
    public class Conta
    {
        public Conta(int numero, Cliente cliente, Correntista correntista, Agencia agencia)
        {
            this.numero = numero;
            this.correntista = correntista;
            this.cliente = cliente;
            this.agencia = agencia;
            this.saldo = 100;
        }
        public Correntista correntista { get; set; }

        public int numero { get; private set; }
        public decimal saldo { get; private set; }
        public decimal limite { get; private set; }
        public Cliente cliente { get; set; }
        public Agencia agencia { get; set; }
        public void Depositar(decimal valor)
        {
            this.saldo += valor;
        }
        public void Sacar(decimal valor)
        {
            this.saldo -= valor;
        }

    }
}