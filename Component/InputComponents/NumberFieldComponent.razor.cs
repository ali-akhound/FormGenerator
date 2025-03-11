using Microsoft.AspNetCore.Components;

namespace FormGenerator.Component.InputComponents
{
    public partial class NumberFieldComponent : BaseInputComponent<int>
    {
        /// <summary>
        /// Minimum value for the number input.
        /// </summary>
        [Parameter] public int Min { get; set; } = int.MinValue;

        /// <summary>
        /// Maximum value for the number input.
        /// </summary>
        [Parameter] public int Max { get; set; } = int.MaxValue;
    }
}
