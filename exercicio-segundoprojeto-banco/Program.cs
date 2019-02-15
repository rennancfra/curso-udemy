using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_segundoprojeto_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco B;
            Console.Write("Digite o número da conta: ");
            int numero = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine();
            double depositoInicial;
            if (resposta == "s")
            {
                Console.Write("Digite o valor do depósito inicial: ");
                depositoInicial = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            else
            {
                depositoInicial = 0;
            }
            B = new Banco(numero, nome, depositoInicial);

            Console.WriteLine("Conta criada:");
            Console.WriteLine("Conta "+ B.numeroDaConta.ToString()+", Titular: "+B.titularDaConta+", Saldo: $ "+B.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double deposito = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B.deposito(deposito);
            Console.WriteLine("Conta atualizada:");
            Console.WriteLine("Conta " + B.numeroDaConta.ToString() + ", Titular: " + B.titularDaConta + ", Saldo: $ " + B.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Digite um valor para saque: ");
            double saque = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B.saque(saque);
            Console.WriteLine("Conta atualizada:");
            Console.WriteLine("Conta " + B.numeroDaConta.ToString() + ", Titular: " + B.titularDaConta + ", Saldo: $ " + B.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();


        }
    }
}
