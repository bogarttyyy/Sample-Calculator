using CalculatorBlazorClient.Services;
using Microsoft.AspNetCore.Components;

namespace CalculatorBlazorClient.Pages
{
    public partial class Calculator : ComponentBase
    {
        private CalculatorService CalculatorService { get; set; }

        private ILogger<Calculator> Logger { get; set; }

        private decimal Input1 { get; set; }
        private decimal Input2 { get; set; }
        private decimal? Result { get; set; }
        private string Error { get; set; }


        protected override void OnInitialized()
        {
            CalculatorService = new CalculatorService();

            Error = string.Empty;
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            return base.OnAfterRenderAsync(firstRender);
        }

        private async Task Add()
        {
            try
            {
                Result = await CalculatorService.GetAdd(Input1, Input2);
                await InvokeAsync(StateHasChanged);
            }
            catch (Exception ex)
            {
                Error = "Failed to fetch data. Contact administrator";
                Logger.LogError(ex.Message);
            }
        }

        private async Task Subtract()
        {
            try
            {
                Result = await CalculatorService.GetSubtract(Input1, Input2);
                await InvokeAsync(StateHasChanged);
            }
            catch (Exception ex)
            {
                Error = "Failed to fetch data. Contact administrator";
                Logger.LogError(ex.Message);
            }
        }

        private async Task Multiply()
        {
            try
            {
                Result = await CalculatorService.GetMultiply(Input1, Input2);
                await InvokeAsync(StateHasChanged);
            }
            catch (Exception ex) 
            {
                Error = "Failed to fetch data. Contact administrator";
                Logger.LogError(ex.Message);
            }
        }

        private async Task Divide()
        {
            try
            {
                Result = await CalculatorService.GetDivide(Input1, Input2);
                await InvokeAsync(StateHasChanged);
            }
            catch (Exception ex)
            {
                Error = "Failed to fetch data. Contact administrator";
                Logger.LogError(ex.Message);
            }
        }
    }
}
