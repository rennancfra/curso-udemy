using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_estatico
{
    class ConversorDeMoeda
    {
        public static double ConversaoDolar(double valor,double cotacao)
        {
            return (((valor * cotacao) / 100)*6) + valor*cotacao;
        }
    }
}
