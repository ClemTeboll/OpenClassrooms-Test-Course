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

        [Fact]
        public void Test_AddManyElements()
        {
            // 1) Arrange
            var calculator = new Calculator();

            // 2) Act (the actual operation)
            var result = calculator.Sum(0.5M, 1, 2, 3, 4, -5.5M);

            // 3) Then, Assert
            Assert.Equal(5, result);
            Assert.IsType<decimal>(result);
        }
    }
    public class CalculatorMemoryTests : IDisposable
    {
        void IDisposable.Dispose() { }
        public void Dispose() { }

        Calculator Calculator { get; }

        public CalculatorMemoryTests()
        {
            Calculator = new Calculator();
        }

        [Fact]
        public void AddNumberTest()
        {
            Calculator.Reset();

            // Act
            Calculator.Sum(3);
            Calculator.Sum(7);

            Assert.Equal(10, Calculator.Current);
        }
    }

    public class MultiplyDivideTests
    {
        [Fact]
        public void Test_MultiplyTwoElements()
        {
            // 1) Arrange
            var calculator = new Calculator();

            // Act (the actual operation)
            var result = calculator.Multiply(10, 5);

            // Then, Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void Test_MultiplyManyElements()
        {
            // 1) Arrange
            var calculator = new Calculator();

            // Act (the actual operation)
            var result = calculator.Multiply(0.5M, 1, 2, 3, 4, -5.5M);

            // Then, Assert
            Assert.Equal(-66, result);
            Assert.IsType<decimal>(result);
        }

        [Fact]
        public void Test_DivideTwoElements()
        {
            // 1) Arrange
            var calculator = new Calculator();

            // Act (the actual operation)
            var result = calculator.Divide(10, 5);

            // Then, Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_DivideManyElements()
        {
            // 1) Arrange
            var calculator = new Calculator();

            // Act (the actual operation)
            var result = calculator.Divide(100, 2, 4);

            // Then, Assert
            Assert.Equal((decimal)12.5, result);
            Assert.IsType<decimal>(result);
        }
    }
}