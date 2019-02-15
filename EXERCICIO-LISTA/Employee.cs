using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EXERCICIO_LISTA
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public Employee(int id, string name, double salary)
        {
             this.id = id;
             this.name = name;
             this.salary = salary;

        }

        public void increaseSalary(double percentage)
        {
            salary = ((salary / 100) * percentage) + salary;
        }

        public override string ToString()
        {
            return id + ", " +
                name + ", " +
                salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
