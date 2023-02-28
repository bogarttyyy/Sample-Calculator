using System.Net.Http.Json;
using System.Runtime.CompilerServices;

namespace CalculatorBlazorClient.Services
{
    public class CalculatorService : ICalculatorService
    {
        public readonly HttpClient httpClient;

        public CalculatorService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7189/");
        }

        public async Task<bool> IsServiceLive()
        {
            var response = await httpClient.GetAsync($"api/Operations/IsLive");

            return response.IsSuccessStatusCode;
        }

        public async Task<decimal?> GetAdd(decimal num1, decimal num2)
        {
            var response = await httpClient.GetAsync($"api/Operations/Add?number1={num1}&number2={num2}");

            return await ProcessResponse(response);
        }

        public async Task<decimal?> GetSubtract(decimal num1, decimal num2)
        {
            var response = await httpClient.GetAsync($"api/Operations/Subtract?number1={num1}&number2={num2}");
            return await ProcessResponse(response);
        }

        public async Task<decimal?> GetMultiply(decimal num1, decimal num2)
        {
            var response = await httpClient.GetAsync($"api/Operations/Multiply?number1={num1}&number2={num2}");
            return await ProcessResponse(response);
        }

        public async Task<decimal?> GetDivide(decimal num1, decimal num2)
        {
            var response = await httpClient.GetAsync($"api/Operations/Divide?number1={num1}&number2={num2}");
            return await ProcessResponse(response);
        }

        private async Task<decimal?> ProcessResponse(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<decimal?>();
            }

            return null;
        }
    }
}
