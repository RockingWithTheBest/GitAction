using ConsoleApp2;
using FluentAssertions;

namespace TestProject
{

    public class ConstructionBudgetCalculatorTests
    {
        [Fact]
        public void BudgetCalculator_NumberOfStages_ReturnValuesBetween1_n_15()
        {
            //Arrange - the number of stages should be between 1 and 15
            var sut = new BudgetCalculator();
            //Act & Assert
            for (int i = 1; i < 15; i++)
            {
                sut.NumberOfStages = (i);
                int result = sut.NumberOfStages;
                result.Should().BeInRange(1, 15);
                result.Should().BePositive();
            }
        }

        [Fact]
        public void BudgetCalculator_OverHeadPercentOfEachStage_ReturnValuesBetween1_n_100()
        {
            //Arrange - the percentage of overhead should be between 1 and 100
            var sut = new BudgetCalculator();
            //Act & Assert
            for (double i = 1; i < 100; i++)
            {
                sut.OverHeadPercentOfEachStage = i;
                double result = sut.OverHeadPercentOfEachStage;
                result.Should().BeInRange(1, 100);
            }
        }

        [Fact]
        public void BudgetCalculator_PercentagePayRoleTax_ReturnValuesBetween0_n_30()
        {
            //Arrange - the percentage of pay role tax should be between 0 and 30
            var sut = new BudgetCalculator();
            //Act & Assert
            for (double i = 0; i < 30; i++)
            {
                sut.PayRollTaxPercentage = i;
                double result = sut.PayRollTaxPercentage;
                result.Should().BeInRange(0, 30);
            }
        }
    }
}
