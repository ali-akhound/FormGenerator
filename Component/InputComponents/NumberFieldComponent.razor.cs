using Microsoft.AspNetCore.Components;

namespace FormGenerator.Component.InputComponents
{
    public partial class NumberFieldComponent : BaseInputComponent<int?>
    {
        /// <summary>
        /// Minimum value for the number input.
        /// </summary>
        [Parameter] public int Min { get; set; } = int.MinValue;

        /// <summary>
        /// Maximum value for the number input.
        /// </summary>
        [Parameter] public int Max { get; set; } = int.MaxValue;
        private string? RangeValidation(int? value)
        {
            if (value == null && Required)
                return $"{Label} is required.";
            if (value < Min || value > Max)
                return $"{Label} must be between {Min} and {Max}.";
            Value = value;
            return null; // No validation errors
        }
    }
}
