namespace aula_02
{
    public class Agencia
    {
        public Agencia(int numero,string nome)
        {
            this.numero = numero;
            this.nome = nome;
        }
        public int numero { get; private set; }
        public string nome { get; private set; }

    }
}