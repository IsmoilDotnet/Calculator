using CalculatorProject;

namespace CalculatorUnitTests
{
    public class CalculatorUnitTest
    {
        [Fact]
        public void TestAdd()
        {
            int x = 32;
            int y = 30;
            int exeptedValue = 62;

            int res = Calculator.Add(x, y);

            Assert.Equal(exeptedValue, res);
        }

        [Theory]
        [InlineData(6, 14, 20)]
        [InlineData(6, 15, 21)]
        [InlineData(5, 3124120, 3124125)]
        public void TestAddWithTheory(int x, int y, int exVal)
        {
            int res = Calculator.Add(x, y);
            Assert.Equal(res, exVal);
        }

        [Fact]
        public void TestSubstract()
        {
            int x = 30;
            int y = 5;
            int exVal = 25;

            int res = Calculator.Substract(x, y);

            Assert.Equal(exVal, res);
        }


        [Theory]
        [InlineData(7, 4, 3)]
        [InlineData(600, 134, 466)]
        [InlineData(10, 0, 10)]
        public void TestSubstractWithTheory(int x, int y, int exVal)
        {
            int res = Calculator.Substract(x, y);

            Assert.Equal(exVal, res);
        }

        [Fact]
        public void TestMultiple()
        {
            int x = 10;
            int y = 5;
            int exValue = 50;

            int res = Calculator.Multiple(x, y);

            Assert.Equal(exValue, res);
        }

        [Theory]
        [InlineData(77, 1, 77)]
        [InlineData(3, 9, 27)]
        [InlineData(123, 3, 369)]
        public void TestMultipleWithTheory(int x, int y, int exValue)
        {
            int res = Calculator.Multiple(x, y);

            Assert.Equal(exValue, res);
        }

        [Fact]
        public void TestDivide()
        {
            int x = 120;
            int y = 6;
            int exVal = 20;

            int res = Calculator.Divide(x, y);

            Assert.Equal(exVal, res);
        }

        [Theory]
        [InlineData(5, 0, 0)]
        [InlineData(10, 10, 1)]
        [InlineData(400, 10, 40)]
        public void TestDivideWithTheory(int x, int y, int exValue)
        {
            if (y == 0)
            {
                Assert.Throws<DivideByZeroException>(() => Calculator.Divide(x, y));
            }
            else
            {
                var res = Calculator.Divide(x, y);
                Assert.Equal(exValue, res);
            }
        }
    }
}