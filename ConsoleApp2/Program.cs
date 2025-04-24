using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            BudgetCalculator cbc = new BudgetCalculator();
            Console.Write("Enter the number of construction stages (1-15): ");
            cbc.NumberOfStages = int.Parse(Console.ReadLine());
        }
    }
}

