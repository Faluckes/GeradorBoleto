using System;

namespace GeradorBoleto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque o Numero do Banco: ");
            string numerodobanco = Console.ReadLine();
            Console.WriteLine("Usuario do Banco: " + numerodobanco + "\n");

            Console.Write("Coloque o Valor do Boleto: ");
            string valordoboleto = Console.ReadLine().Replace(".", ",");
            double valorboletocerto = default;
            if (double.TryParse(valordoboleto, out double resultado))
            {
                valorboletocerto = resultado;
                Console.WriteLine("O Valor do Boleto é de R$" + valordoboleto + "\n");
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }

            Boleto boleto = new Boleto(numerodobanco, valorboletocerto);


            Console.WriteLine("Data do Boleto: " + boleto.Data);

            Console.WriteLine("Banco: " + boleto.NumeroBanco + "\n" + "Valor: R$" + boleto.ValorBoleto);

            Console.WriteLine("Número do Boleto: " + boleto.NumeroBoleto);

            Console.WriteLine(boleto.ValorTotal);

            Console.ReadLine();
        }
    }
}