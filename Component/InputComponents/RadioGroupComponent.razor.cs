using Microsoft.AspNetCore.Components;

namespace FormGenerator.Component.InputComponents
{
    public partial class RadioGroupComponent: BaseInputComponent<string>
    {
        /// <summary>
        /// List of options for the radio button group.
        /// </summary>
        [Parameter] public List<string> Options { get; set; } = new();
    }
}
