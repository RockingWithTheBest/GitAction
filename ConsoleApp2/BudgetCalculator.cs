using System;
namespace ConsoleApp2
{
    public class BudgetCalculator
    {
        private int numberOfStages;
        private double areaOfEachStage;
        private double materialCostOfEachStage;
        private double overHeadPercentOfEachStage;
        private int numberOfEmployeeOfEachStage;
        private double averageSalaryOfAnEmployee;
        private double payRollTaxPercentage;
        private double additionalExpenses;

        double[] area;
        double[] materialCosts;
        double[] overheadPercentages;
        int[] numberOfEmployees;


        public double PayRollTaxPercentage
        {
            get { return this.payRollTaxPercentage; }
            set { payRollTaxPercentage = value; }
        }
        public int NumberOfStages
        {
            get { return numberOfStages; }
            set
            {
                numberOfStages = value;
                area = new double[numberOfStages];
                materialCosts = new double[numberOfStages];
                overheadPercentages = new double[numberOfStages];
                numberOfEmployees = new int[numberOfStages];
            }

        }

        public double OverHeadPercentOfEachStage
        {
            get { return overHeadPercentOfEachStage; }
            set { overHeadPercentOfEachStage = value; }
        }

        public void numberOfConstructionStages(int numberOfStages)
        {
            if (numberOfStages < 1 || numberOfStages > 15)
            {
                Console.WriteLine("Invalid number of stages. Must be between 1 and 15.");
                return;
            }
            else
            {
                Console.WriteLine("Valid number of stages");
                return;
            }
        }

        public void ConstructionOPeration(int numberOfStages)
        {
            for (int i = 0; i < numberOfStages; i++)
            {
                Console.Write($"Enter area for stage {i + 1} (in square meters): ");
                area[i] = double.Parse(Console.ReadLine());

                Console.Write($"Enter material cost for stage {i + 1} (in rubles): ");
                materialCosts[i] = double.Parse(Console.ReadLine());

                Console.Write($"Enter overhead percentage for stage {i + 1} (0-100): ");
                overheadPercentages[i] = double.Parse(Console.ReadLine());
                if (overheadPercentages[i] < 0 || overheadPercentages[i] > 100)
                {
                    Console.WriteLine("Invalid overhead percentage. Must be between 0 and 100.");
                    return;
                }

                Console.Write($"Enter number of workers for stage {i + 1}: ");
                numberOfEmployees[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter average salary per worker (in rubles): ");
            averageSalaryOfAnEmployee = double.Parse(Console.ReadLine());

            Console.Write("Enter tax percentage on salary (0-30): ");
            payRollTaxPercentage = double.Parse(Console.ReadLine());

            if (payRollTaxPercentage < 0 || payRollTaxPercentage > 30)
            {
                Console.WriteLine("Invalid tax percentage. Value must be between 0 and 30.");
                return;
            }

            Console.Write("Enter additional expenses (in rubles): ");
            additionalExpenses = double.Parse(Console.ReadLine());


            double totalMaterialCost = 0;
            double totalOverhead = 0;
            double totalSalaries = 0;

            for (int i = 0; i < numberOfStages; i++)
            {
                totalMaterialCost += materialCosts[i];
                totalOverhead += materialCosts[i] * (overheadPercentages[i] / 100);
                totalSalaries += numberOfEmployees[i] * averageSalaryOfAnEmployee;
            }
            double salaryTax = totalSalaries * (payRollTaxPercentage / 100);
            double Total_Costs = totalMaterialCost + totalOverhead + totalSalaries + additionalExpenses;

            Console.WriteLine($"\nTotal Material Cost: {totalMaterialCost} rubles");
            Console.WriteLine($"Total Overhead: {totalOverhead} rubles");
            Console.WriteLine($"Total Salaries: {totalSalaries} rubles");
            Console.WriteLine($"Salary Tax: {salaryTax} rubles");
            Console.WriteLine($"Total Expenses: {Total_Costs} rubles");
        }
    }
}

