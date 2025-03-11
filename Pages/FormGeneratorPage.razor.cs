using FormGenerator.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using MudBlazor;
using System.Net.Http.Json;
using System.Text.Json;

namespace FormGenerator.Pages
{
    public partial class FormGeneratorPage
    {
        [Inject] private HttpClient http { get; set; }
        FormConfiguration formConfiguration = new();
        string errorMessage = string.Empty;
        protected override async Task OnInitializedAsync()
        {
            // Load the JSON of the field configuration (simulated here, replace with actual API call if needed)
            try
            {
                formConfiguration = await http.GetFromJsonAsync<FormConfiguration>("sample-data/form-fields.json") ?? new();
            }
            catch (HttpRequestException httpEx)
            {
                errorMessage = $"HTTP error: {httpEx.Message}";
                formConfiguration = new();
            }
            catch (JsonException jsonEx)
            {
                errorMessage = $"JSON parsing error: {jsonEx.Message}";
                formConfiguration = new();
            }
            catch (Exception ex)
            {
                errorMessage = $"An unexpected error occurred: {ex.Message}";
                formConfiguration = new();
            }
        }
    }
}
