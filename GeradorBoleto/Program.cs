using System;

namespace GeradorBoleto
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Boleto boleto = new Boleto(299.99, "334-3");

            Console.WriteLine("Data do Boleto: " + boleto.Data);

            Console.WriteLine("Banco: " + boleto.NumeroBanco + "\n" + "Valor: R$" + boleto.ValorBoleto);

            Console.WriteLine("Número do Boleto: " + boleto.NumeroBoleto);

            Console.WriteLine(boleto.ValorTotal.Remove(32, 1));

            Console.ReadLine();
        }
    }
}