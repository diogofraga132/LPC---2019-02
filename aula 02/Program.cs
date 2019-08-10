using System;

namespace aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta objContaJoao = new Conta(1234,"João",new Correntista(123,"Correntista do João"));
            objContaJoao.Depositar(500);
            w($"Num. Conta: {objContaJoao.saldo}.");
            
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
