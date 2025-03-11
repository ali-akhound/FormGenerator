namespace FormGenerator.Model
{
    /// <summary>
    /// Represents a dynamic form with a title and a collection of fields.
    /// </summary>
    public class DynamicForm
    {
        /// <summary>
        /// The title of the form.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The list of form fields that define the form structure.
        /// </summary>
        public List<FormField> Fields { get; set; } = new();
    }
}
