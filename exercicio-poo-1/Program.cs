using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace exercicio_poo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 1 --------------------------------------------------------------------------------------------
            /*
            Retangulo R;
            R = new Retangulo();

            Console.Write("Largura: ");
            R.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            R.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("AREA = "+R.area().ToString("F2", CultureInfo.InvariantCulture)+", PERIMETRO = "+ R.perimetro().ToString("F2", CultureInfo.InvariantCulture)+", DIAGONAL = "+R.diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();*/

            //EXERCICIO 2 --------------------------------------------------------------------------------------------
            Funcionario F;
            F = new Funcionario();
            Console.Write("Nome: ");
            F.nome = Console.ReadLine();

            Console.Write("Salario bruto: ");
            F.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Desconto: ");
            F.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Dados do funcionário: " + F.nome + ", R$" + F.salarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem ? ");
            F.aumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.Write("Dados do funcionário: "+F.nome+", R$"+F.salarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
