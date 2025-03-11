using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace FormGenerator.Component.InputComponents
{
    public partial class DropdownFieldComponent : BaseInputComponent<string>
    {
        /// <summary>
        /// List of options for the dropdown.
        /// </summary>
        [Parameter] public List<string> Options { get; set; } = new();
    }
}
