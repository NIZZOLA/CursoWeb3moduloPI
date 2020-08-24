using ConsoleAula2PI.Models;
using System;

namespace ConsoleAula2PI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Pessoa p = new Pessoa();
            p.Codigo = 1;
            p.Nome = "JOÃO";
            p.Email = "joao@itu.com.br";
            p.Cpf = "111.222.333-44";
            /*
            Pessoa p2 = new Pessoa() { Codigo = 2, Cpf = "177.222.444-33", Nome = "JOSE DA SILVA" , Email = "AAA@A.COM" };

            var p3 = new Pessoa() { Codigo = 2, Cpf = "177.222.444-33", Nome = "JOSE DA SILVA", Email = "AAA@A.COM" };

            if (p2.Valido())
                Console.WriteLine("O objeto é válido !");
            else
                Console.WriteLine("O objeto não é valido");
            */
            ContaCorrente cta = new ContaCorrente();
            cta.Agencia = 1;
            cta.Conta = 234;
            cta.Correntista = p;
            /*
            ContaCorrente cta2 = new ContaCorrente();
            cta2.Agencia = 1;
            cta2.Conta = 234;
            cta2.Correntista = new Pessoa() { Codigo = 44, Nome = "Benedito", Cpf = "4444", Email = "x.com" };


            ContaCorrente cta3 = new ContaCorrente();
            cta3.Agencia = 1;
            cta3.Conta = 234;
            cta3.Correntista.Nome = "PAULO";
            cta3.Correntista.Codigo = 48484;
            */

            Console.WriteLine("Valor a depositar:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            cta.Depositar(valor);
            Console.WriteLine("Saldo atual:" + cta.VerSaldo());

            Console.WriteLine("Valor a sacar:");
            valor = Convert.ToDecimal(Console.ReadLine());

            if (!cta.Sacar(valor))
                Console.WriteLine("Saldo Insuficiente !");

            Console.WriteLine("Valor a sacar:");
            valor = Convert.ToDecimal(Console.ReadLine());

            if (!cta.Sacar(valor))
                Console.WriteLine("Saldo Insuficiente !");


            Console.WriteLine("Saldo restante:" + cta.VerSaldo());

            foreach (var linha in cta.Historico)
            {
                Console.WriteLine($"| {linha.DataDaTransacao} | {linha.Operacao} | {linha.Valor} |");
            }


           // ContaPoupança poup = new ContaPoupança();
            



        }
    }
}
