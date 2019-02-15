using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTUDO_LISTA
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAÇÃO DA LISTA
            List<string> list = new List<string>();


            //ADICIONAR ELEMENTOS NA LISTA
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");//ADICIONAR ELEMENTOS EM DETERMINADA POSIÇÃO DA LISTA OBS:SE HOUVER ALGUM ELEMENTO NA LISTA, O MESMO SERÁ DESLOCADO PARA A PRÓXIMA POSIÇÃO

            //FOREACH PARA LISTAR O CONTEÚDO DA LISTA
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //MÉTODO FIND. PROCURA DETERMINADO ITEM DA LISTA COM BASE EM UMA FUNÇÃO
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            //LISTAR O NÚMERO DE POSIÇÕES DA LISTA
            Console.WriteLine(list.Count);

            //MÉTODO FINDLAST. PROCURA O ÚLTIMO ITEM DA LISTA COM BASE EM UMA FUNÇÃO
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);


            //MÉTODO FINDINDEX. PROCURA DETERMINADA POSIÇÃO DA LISTA COM BASE EM UMA FUNÇÃO
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': "+pos1.ToString());

            //MÉTODO FINDLASTINDEX. PROCURA A ÚLTIMA POSIÇÃO DA LISTA COM BASE EM UMA FUNÇÃO
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + pos2.ToString());

            //MÉTODO FINDALL. ATRÍTUBI VALOR A UMA NOVA LISTA INSTANCIADA COM BASE EM UMA FUNÇÃO DA LISTA ANTIGA
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------------------------");

            //FOREACH PARA LISTAR O CONTEUDO DA LISTA
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            //remover item da lista
            list.Remove("Alex");
            //FOREACH PARA LISTAR O CONTEUDO DA LISTA
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //remove com base em função
            list.RemoveAll(x=>x[0] == 'M');
            //FOREACH PARA LISTAR O CONTEUDO DA LISTA
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //remove o elemento pela posição dele
            list.RemoveAt(2);

            //removerange, remove elementos de uma posição inicial, e no segundo parametro tem que inserir o numero de elementos que serão removidos
            list.RemoveRange(2, 2);

            Console.ReadKey();
        }
    }
}
