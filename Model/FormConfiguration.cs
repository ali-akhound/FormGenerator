namespace FormGenerator.Model
{
    /// <summary>
    /// Represents the dynamic form configuration.
    /// </summary>
    public class FormConfiguration
    {
        public string Title { get; set; } = string.Empty;
        public List<FormField> Fields { get; set; } = new();
    }
}
