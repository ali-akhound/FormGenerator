using FormGenerator.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Text.Json;
using static MudBlazor.Colors;

namespace FormGenerator.Component
{
    /// <summary>
    /// Dynamic form generator component that builds a form based on a JSON configuration.
    /// </summary>
    public partial class FormGeneratorComponent
    {
        private MudForm MudFormRef = default!;
        private Dictionary<string, object?> FormModel;
        private string Output = string.Empty;
        /// <summary>
        /// Form configuration loaded from JSON.
        /// </summary>
        [Parameter] public FormConfiguration FormConfig { get; set; } = new();

        /// <summary>
        /// Handles value change events from dynamic input components.
        /// </summary>
        private void HandleValueChanged(string key, object? value)
        {
            FormModel[key] = value;
        }

        /// <summary>
        /// Submits the form and validates it.
        /// </summary>
        private async Task SubmitForm()
        {
            await MudFormRef.Validate();
            if (MudFormRef.IsValid)
            {
                Output = JsonSerializer.Serialize(FormModel);
            }            
        }
        protected override void OnParametersSet()
        {
            if (FormConfig != null && FormConfig.Fields.Count > 0)
            {
                FormModel = new();
                foreach (var field in FormConfig.Fields)
                {
                    // Initialize default value based on field type
                    object? defaultValue = field.Type.ToLower() switch
                    {
                        "text" => "",
                        "email" => "",
                        "number" => 0,
                        "dropdown" => null,
                        "checkbox" => false,
                        "radio" => null,
                        "date" => null,
                        "time" => null,
                        _ => null
                    };
                    FormModel.Add(field.Label, defaultValue);
                }
            }
        }
    }
}
