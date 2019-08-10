namespace aula_02
{
    public class Conta
    {
        public Conta(int numero, string titular,Correntista correntista)
        {
            this.correntista = correntista;
            this.numero = numero;
            this.titular = titular;
        }
        public Correntista correntista {get; set;}

        public int numero { get; private set; }
        public string titular { get; private set; }
        public decimal saldo { get; private set; }

        public void Depositar(decimal valor)
        {
            this.saldo -= valor;
        }
        public void Sacar(decimal valor)
        {
            this.saldo -= valor;
        }

    }
}