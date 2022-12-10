using CalculatorProgram;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_AddTwoElements()
        {
            // 1) Arrange
            var calculator = new Calculator();

            // 2) Act (the actual operation)
            var result = calculator.Sum(1, 1);

            // 3) Then, Assert
            Assert.Equal(2, result);
        }
    }
}