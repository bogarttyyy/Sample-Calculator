namespace CalculatorBlazorClient.Services
{
    public interface ICalculatorService
    {
        public Task<decimal?> GetAdd(decimal num1, decimal num2);
        public Task<decimal?> GetSubtract(decimal num1, decimal num2);
        public Task<decimal?> GetMultiply(decimal num1, decimal num2);
        public Task<decimal?> GetDivide(decimal num1, decimal num2);
    }
}
