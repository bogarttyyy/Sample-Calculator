using CalculatorAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAPITest
{
    public class OperationsControllerTest
    {
        private readonly OperationsController _controller;
        public OperationsControllerTest()
        {
            _controller = new OperationsController();
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllValues()
        {
            // Act
            var okResult = _controller.Get();

            // Assert
            var items = Assert.IsAssignableFrom<IEnumerable<string>>(okResult);
            Assert.Equal(2, items.Count());
        }
    }
}
