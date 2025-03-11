using Microsoft.AspNetCore.Components;

namespace FormGenerator.Component.InputComponents
{
    /// <summary>
    /// Text input field component that inherits common properties.
    /// </summary>
    public partial class EmailFieldComponent : BaseInputComponent<string>
    {
        string ErrorMessage = string.Empty;
        private string ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) && Required)
            {
                ErrorMessage = $"{Label} is required.";
                return ErrorMessage;
            }
            if (!string.IsNullOrWhiteSpace(email))
            {
                var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailRegex))
                {
                    ErrorMessage = $"Invalid {Label} format.";
                    return ErrorMessage;
                }
            }
            Value = email;
            return null; // Validation success
        }
    }
}
