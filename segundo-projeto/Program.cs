using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace segundo_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto P;

            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Nome: ");
            
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            P = new Produto(nome, preco, quantidade);

            /* Console.WriteLine();

             Console.WriteLine("Dados do Produto: " + P);
             Console.WriteLine();

             Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
             qte = int.Parse(Console.ReadLine());
             P.realizarEntrada(qte);

             Console.WriteLine();
             Console.Write("Dados atualizados: "+P);

             Console.WriteLine();

             Console.Write("Digite a quantidade de produtos que sairam no estoque: ");
             qte = int.Parse(Console.ReadLine());
             P.realizarSaida(qte);

             Console.Write("Dados atualizados: " + P);*/

            Console.WriteLine(P.nome);


            Console.ReadKey();

        }
    }
}
