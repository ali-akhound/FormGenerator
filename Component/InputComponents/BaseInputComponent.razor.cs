using Microsoft.AspNetCore.Components;

namespace FormGenerator.Component.InputComponents
{
    public partial class BaseInputComponent<T>
    {
        /// <summary>
        /// Label for the input field.
        /// </summary>
        [Parameter]
        public string Label
        {
            get => _label;
            set => _label = value;
        }
        private string _label = string.Empty;
        /// <summary>
        /// Determines whether the field is required.
        /// </summary>
        [Parameter]
        public bool Required
        {
            get => _required;
            set => _required = value;
        }
        private bool _required = false;
        /// <summary>
        /// Determines whether the field is required.
        /// </summary>
        [Parameter]
        public string RequiredError
        {
            get => string.IsNullOrEmpty(_requiredError) ? $"{_label} is required" : _requiredError;
            set => _requiredError = value;
        }
        private string _requiredError = string.Empty;
        /// <summary>
        /// Holds the value of the input.
        /// </summary>
        [Parameter] public T? Value { get; set; }

        /// <summary>
        /// Child content for the input field.
        /// </summary>
        [Parameter] public RenderFragment? ChildContent { get; set; } = default!;
        /// <summary>
        /// Event callback to notify parent when the value changes.
        /// </summary>
        [Parameter] public EventCallback<T> ValueChanged { get; set; }
        /// <summary>
        /// Shows a button to clear this input's value.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        public bool Clearable { get; set; } = true;
    }
}
