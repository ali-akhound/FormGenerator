using Microsoft.AspNetCore.Components;

namespace FormGenerator.Component.InputComponents
{
    /// <summary>
    /// Text input field component that inherits common properties.
    /// </summary>
    public partial class EmailFieldComponent : BaseInputComponent<string>
    {
        private string ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) && Required)
                return "Email is required.";
            if (!string.IsNullOrWhiteSpace(email))
            {
                var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailRegex))
                    return "Invalid email format.";
            }
            Value = email;
            return null; // Validation success
        }
    }
}
