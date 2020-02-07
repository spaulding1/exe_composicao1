using Composicao1.Entities;
using Composicao1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Composicao1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter department's name: ");
            string departamento = Console.ReadLine();
            Console.WriteLine("(=== Enter worker data ===)");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level =Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Department dept = new Department(departamento);
            Worker trabalhador = new Worker(nome, baseSalary, level, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i =1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contrato = new HourContract(data, valuePerHour, hours);
                trabalhador.AddContract(contrato);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0,2));
            int ano = int.Parse(mesEano.Substring(3));
            Console.WriteLine("Name: "+trabalhador.Name);
            Console.WriteLine("Department: "+trabalhador.Department.Name);
            Console.WriteLine("Income for "+mesEano+": "+trabalhador.Income(ano,mes).ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
