using System.Collections.Generic;

namespace aula_02
{
    public class Correntista
    {
        public Correntista(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public int codigo   { get; private set; }   
        public string nome { get; private set; }    
        public List<Conta> contas {get; set;}
    }
}