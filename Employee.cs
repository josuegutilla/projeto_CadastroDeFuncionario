using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_lista
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void incleaseSalary(double porcentagem)
        {
            Salary += (Salary * porcentagem) / 100;
        }

        public override string ToString()
        {
            return Id 
                + ", " 
                + Name 
                + ", " 
                + Salary;
        }

    }
}
