using System.Diagnostics.Metrics;
using System.Globalization;

namespace Exercicio_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão cadastrados? ");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Employee> list = new List<Employee>();

            for(int i  = 1; i <= quant; i++)
            {
                Console.WriteLine("Employee #" + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, nome, salario));
            }

            Console.WriteLine();
            Console.Write("Informe o id do funcionário que terá aumento salarial: ");
            double idAumento = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Employee emp = list.Find(x => x.Id == idAumento);

            if(emp != null)
            {
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine());
                emp.incleaseSalary(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse id não existe!");
            }

            Console.WriteLine();
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
