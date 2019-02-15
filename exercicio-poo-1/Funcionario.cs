using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_poo_1
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto, desconto;

        public double salarioLiquido()
        {
            return salarioBruto - desconto;
        }

        public void aumentarSalario(double porcentagem)
        {
             salarioBruto = salarioBruto + ((salarioBruto * porcentagem) / 100);
        }
    }
}
