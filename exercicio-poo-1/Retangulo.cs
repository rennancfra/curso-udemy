using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_poo_1
{
    class Retangulo
    {
        public double largura;
        public double altura;

        public double area()
        {
            return largura * altura;
        }

        public double perimetro()
        {
            return (2 * (largura + altura));
        }

        public double diagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
    }
}
