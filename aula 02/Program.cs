using System;

namespace aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta objContaPedro = new Conta(1234,new Cliente (123,"Pedro"),new Correntista(123,"Correntista do Pedro"), new Agencia(321,"Banco do Brasil"));
            objContaPedro.Depositar(500);
            w($"Num. Conta: {objContaPedro.saldo}.");
            
            r();
        }
        public static void w(string msg)
        {
            Console.WriteLine(msg);

        }
        public static void r()
        {
            w("Press any key");
            Console.ReadLine();
        }
    }
}
