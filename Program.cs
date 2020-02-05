using Composicao1.Entities;
using Composicao1.Entities.Enums;
using System;

namespace Composicao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker trabalhador = new Worker();
            Console.Write("Enter department's name: ");
            Department departamento = new Department(Console.ReadLine());
            Console.WriteLine("(=== Enter worker data ===)");
            Console.Write("Name: ");
            trabalhador.Name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            trabalhador.Level =Enum.Parse<WorkerLevel>(Console.ReadLine());

        }
    }
}
