using CalculatorAPI.Libraries;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPITest.LibraryTests
{
    public class OperationsTest
    {
        [Fact]
        public void Add_WhenCalled_ShouldAddValues()
        {
            Assert.Equal(10, Operations.Add(2, 8));
            Assert.Equal(12, Operations.Add(6, 6));
            Assert.Equal(88, Operations.Add(24, 64));
        }
        [Fact]
        public void Subtract_WhenCalled_ShouldSubtractValues()
        {
            Assert.Equal(-6, Operations.Subtract(2, 8));
            Assert.Equal(0, Operations.Subtract(6, 6));
            Assert.Equal(-40, Operations.Subtract(24, 64));
        }
        [Fact]
        public void Multiply_WhenCalled_ShouldMultiplyValues()
        {
            Assert.Equal(16, Operations.Multiply(2, 8));
            Assert.Equal(36, Operations.Multiply(6, 6));
            Assert.Equal(1536, Operations.Multiply(24, 64));
        }
        [Fact]
        public void Divide_WhenCalled_ShouldDivideValues()
        {
            Assert.Equal(4, Operations.Divide(8, 2));
            Assert.Equal(1, Operations.Divide(6, 6));
            Assert.Equal(8, Operations.Divide(64, 8));
        }
    }
}
