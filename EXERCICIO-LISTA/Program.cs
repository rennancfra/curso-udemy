using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_LISTA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            int _numberEmployees;

            Console.Write("How many employees will be registered? ");
            _numberEmployees = int.Parse(Console.ReadLine());
            int conta = 1;
            for (int i = 0; i < _numberEmployees; i++)
            {
                
                Console.WriteLine("Employee #"+ conta.ToString()+": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(id, name, salary));
                conta++;
            }
            Console.WriteLine();

            Console.Write("Enter the employee id that will have salary increase: ");
            int idemployee = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Employee em = list.Find(x => x.id == idemployee);

            em.increaseSalary(percentage);

            Console.WriteLine("Updated list od employees: ");

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
            

        }
    }
}
