using CalculatorAPI.Controllers;

namespace CalculatorAPITest
{
    public class OperationsTest
    {
        private readonly OperationsController _controller;

        public OperationsTest()
        {
            _controller = new OperationsController();
        }

        [Fact]
        public void Get_WhenCalled_AddsValues()
        {
            Assert.Equal(10, _controller.GetByAddition(2, 8));
            Assert.Equal(12, _controller.GetByAddition(6, 6));
            Assert.Equal(88, _controller.GetByAddition(24, 64));

            Assert.NotEqual(1, _controller.GetByAddition(4, 3));
            Assert.NotEqual(25, _controller.GetByAddition(5, 5));
            Assert.NotEqual(13, _controller.GetByAddition(39, 3));
        }

        [Fact]
        public void Get_WhenCalled_SubtractsValues()
        {
            Assert.Equal(1, _controller.GetBySubtraction(4, 3));
            Assert.Equal(0, _controller.GetBySubtraction(6, 6));
            Assert.Equal(40, _controller.GetBySubtraction(64, 24));

            Assert.NotEqual(10, _controller.GetBySubtraction(2, 8));
            Assert.NotEqual(25, _controller.GetBySubtraction(5, 5));
            Assert.NotEqual(13, _controller.GetBySubtraction(39, 3));
        }

        [Fact]
        public void Get_WhenCalled_MultipliesValues()
        {
            Assert.Equal(12, _controller.GetByMultiplication(4, 3));
            Assert.Equal(36, _controller.GetByMultiplication(6, 6));
            Assert.Equal(1536, _controller.GetByMultiplication(64, 24));

            Assert.NotEqual(10, _controller.GetByMultiplication(2, 8));
            Assert.NotEqual(0, _controller.GetByMultiplication(5, 5));
            Assert.NotEqual(13, _controller.GetByMultiplication(39, 3));
        }

        [Fact]
        public void Get_WhenCalled_DividesValues()
        {
            Assert.Equal(4, _controller.GetByDivision(12, 3));
            Assert.Equal(1, _controller.GetByDivision(6, 6));
            Assert.Equal(3, _controller.GetByDivision(72, 24));

            Assert.NotEqual(10, _controller.GetByDivision(2, 8));
            Assert.NotEqual(25, _controller.GetByDivision(5, 5));
            Assert.NotEqual(10, _controller.GetByDivision(13, 3));
        }
    }
}
