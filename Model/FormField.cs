namespace FormGenerator.Model
{
    /// <summary>
    /// Represents a field in a dynamic form.
    /// </summary>
    public class FormField
    {
        /// <summary>
        /// The type of the field (e.g., text, email, number, dropdown, checkbox).
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// The label of the field displayed to the user.
        /// </summary>
        public string Label { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether the field is required.
        /// </summary>
        public bool Required { get; set; } = false;

        /// <summary>
        /// The minimum value for a number field (if applicable).
        /// </summary>
        public int? Min { get; set; }=int.MinValue;

        /// <summary>
        /// The maximum value for a number field (if applicable).
        /// </summary>
        public int? Max { get; set; } = int.MaxValue;

        /// <summary>
        /// The list of values for a dropdown field (if applicable).
        /// </summary>
        public List<string>? Values { get; set; }
    }
}
