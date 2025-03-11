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
        string ErrorMessage = string.Empty;
        private string? RangeValidation(int? value)
        {
            if (value == null && Required)
            {
                ErrorMessage = $"{Label} is required.";
                return ErrorMessage;
            }
            if (value < Min || value > Max)
            {
                ErrorMessage = $"{Label} must be between {Min} and {Max}."; ;
                return ErrorMessage;
            }
            Value = value;
            return null; // No validation errors
        }
    }
}
