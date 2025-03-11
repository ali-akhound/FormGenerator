using FormGenerator.Model;
using Microsoft.AspNetCore.Components;

namespace FormGenerator.Component
{
    public partial class DynamicFieldComponent
    {
        /// <summary>
        /// The field configuration for this dynamic component.
        /// </summary>
        [Parameter] public FormField Field { get; set; } = default!;

        /// <summary>
        /// Current value of the field.
        /// </summary>
        [Parameter] public object? FieldValue { get; set; }


        /// <summary>
        /// Handles value changes and notifies the parent form.
        /// </summary>
        private async Task OnValueChanged(object? value)
        {
            FieldValue = value;
            await ValueChanged.InvokeAsync(value);
        }

    }
}
