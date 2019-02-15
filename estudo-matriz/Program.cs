using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //instância matriz  
            double[,] mat = new double[2, 3];

            //número total de espaços da matriz
            Console.WriteLine(mat.Length);

            //número de linhas da matriz
            Console.WriteLine(mat.Rank);

            //primeira dimensão da matriz (****2****,3)
            Console.WriteLine(mat.GetLength(0));

            //primeira dimensão da matriz (2,****3****)
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
