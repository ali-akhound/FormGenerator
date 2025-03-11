using FormGenerator.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using MudBlazor;
using System.Net.Http.Json;

namespace FormGenerator.Pages
{
    public partial class FormGeneratorPage
    {
        [Inject] private HttpClient http { get; set; }
        FormConfiguration formConfiguration = new();
        protected override async Task OnInitializedAsync()
        {
            // Load the JSON of the field configuration (simulated here, replace with actual API call if needed)
            formConfiguration = await http.GetFromJsonAsync<FormConfiguration>("sample-data/form-fields.json") ?? new();           
        }
    }
}
