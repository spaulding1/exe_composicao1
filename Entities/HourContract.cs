using System;

namespace Composicao1.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valorPorHora, int horas)
        {
            Date = date;
            ValuePerHour = valorPorHora;
            Hours = horas;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
