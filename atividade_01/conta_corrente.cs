using System;

namespace ContaCorrenteUniversitaria
{
    class Conta
    {
        public static int NumeroConta;
        private string titular;
        private float saldo = 0, limite = 500;
        private string StatusContas{get{return saldo<0?"negativo":"positivo";}}
        private float SaldoTotal{get{return saldo+limite;}}
        
        public void Depositar(float valor)
        {
            if(valor > 0)
            {
                saldo += valor;
            }
        }

        public void Sacar(float valor)
        {
            if(valor <= SaldoTotal)
            {
                saldo -= valor;
            }
        }

        public void Mostrar_inf()
        {
            Console.WriteLine($"Conta: {NumeroConta}");
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Saldo: {saldo:F2}");
            Console.WriteLine($"Limite: {limite:F2}");
            Console.WriteLine($"Saldo total: {SaldoTotal:F2}");
            Console.WriteLine($"Status Conta: {StatusContas}");
        }

        public Conta(int numeroConta, string TitularConta){
            NumeroConta = numeroConta;
            titular = TitularConta;
        }
    }

    public class Program
    {
        static void Main()
        {
            Conta conta = new Conta(1, "Carlos Manoel");
            
            Console.Write("depositar: ");conta.Depositar(float.Parse(Console.ReadLine()));
            Console.Write("sacar: ");conta.Sacar(float.Parse(Console.ReadLine()));

            for(int i=0;i<40;i++)Console.Write("=");Console.Write("\n");
            conta.Mostrar_inf();
            for(int i=0;i<40;i++)Console.Write("=");Console.Write("\n");
        }
    }
}