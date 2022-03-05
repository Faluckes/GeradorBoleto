using System;

namespace GeradorBoleto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Coloque seu numero do banco.
            Console.Write("Coloque o Numero do Banco: ");
            string numerodobanco = Console.ReadLine();
            Console.WriteLine("Usuario do Banco: " + numerodobanco + "\n");

            double valorboletocerto = default;
            bool iConventer = false;

            // Coloque um Valor Válido para gerar o seu boleto!
            while (!iConventer)
            {
                Console.Write("Coloque o Valor do Boleto: ");
                string valordoboleto = Console.ReadLine().Replace(".", ",");

                if (double.TryParse(valordoboleto, out double resultado))
                {

                    Console.WriteLine($"O Valor do Boleto é de R$ {valordoboleto}" + "\n");
                    valorboletocerto = resultado;
                    iConventer = true;
                }
                else
                {
                    Console.WriteLine("Valor invalido, por favor coloque um valor valido!");
                }
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