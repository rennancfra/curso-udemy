using System;
using System.Globalization;

namespace primeiro_projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Exercício 1
            int volumeFrasco = int.Parse(Console.ReadLine());
            int vazaoBomba = int.Parse(Console.ReadLine());
            int tempo = int.Parse(Console.ReadLine());

            int vazaoTotal = vazaoBomba *tempo;

            int saida = volumeFrasco - vazaoTotal;
            if (volumeFrasco < vazaoTotal)
            {
                Console.WriteLine("nao eh possivel");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("O volume restante é:" + saida.ToString());
                Console.ReadKey();


            }*/

            //----------------------------------------------------------------------------

            //Exercício 2
            /*double N1, N2, N3, soma;
            string[] vet = Console.ReadLine().Split(' ');
            N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            soma = N1 + N2 + N3;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            if (soma < 60.0)
            {
                Console.WriteLine("DEPENDENCIA");
            }
            Console.ReadLine();*/

            //AULA 1------------------------------------
            Triangulo X, Y;
            double areaX, areaY;

            X = new Triangulo();
            Y = new Triangulo();

            X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = X.area();
            areaY = Y.area();

            Console.WriteLine("AREA DO TRIANGULO X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DO TRIANGULO Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: X");
            }else if (areaY > areaX)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: Y");
            }
            else
            {
                Console.WriteLine("AREAS IGUAIS");
            }
            Console.ReadKey();
        }
    }
}
