using CalculatorAPI.Controllers;

namespace CalculatorAPITest
{
    public class OperationsTest
    {
        [Fact]
        public void Get_WhenCalled_AddsValues()
        {
            var addController = new AddController();

            Assert.Equal(10, addController.Get(2, 8));
            Assert.Equal(12, addController.Get(6, 6));
            Assert.Equal(88, addController.Get(24, 64));

            Assert.NotEqual(1, addController.Get(4, 3));
            Assert.NotEqual(25, addController.Get(5, 5));
            Assert.NotEqual(13, addController.Get(39, 3));
        }
    }
}
