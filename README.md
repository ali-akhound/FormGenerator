# Blazor Dynamic Form Generator

This project is a Blazor WebAssembly application designed to dynamically generate forms based on JSON configuration files. It leverages MudBlazor for enhanced UI and user experience.

## Project Overview

This application reads form field configurations from JSON files located in `wwwroot/sample-data`. Each JSON file defines the structure and properties of a form, allowing for flexible and dynamic form creation.

## Features

* **Dynamic Form Generation:** Forms are generated based on JSON configuration, allowing for easy updates and modifications without recompiling.
* **Component-Based Architecture:** Each field type (text, email, number, dropdown, checkbox, date, time, radio) is implemented as a separate component for easy maintenance and debugging.
* **MudBlazor Integration:** Utilizes MudBlazor for a modern and responsive user interface.
* **Base Component Wrapper:** All field components inherit from a base component, providing a consistent interface and reducing code duplication.
* **Customizable Field Options:** Date, time, and radio components support options read directly from the JSON configuration.

## Assumptions

* **JSON Configuration:**
    * Form configurations are stored in JSON files within the `wwwroot/sample-data` directory.
    * Each JSON file represents a single form.
    * The JSON structure adheres to the following format:
        ```json
        {
          "title": "Form Title",
          "fields": [
            {
              "type": "text",
              "label": "Field Label",
              "required": false,
              "min": null,
              "max": null,
              "values": null,
              "placeholder": null,
              "value": null,
              "readOnly": false,
              "htmlAttributes": null
            },
            // ... more fields
          ]
        }
        ```
    * The `type` field corresponds to the `InputType` enum (text, email, number, dropdown, checkbox, date, time, radio).
* **Data Types:**
    * Number fields expect integer values.
    * Date and Time fields expect standard date and time formats.
* **MudBlazor:**
    * The project relies on the MudBlazor library for UI components. Ensure MudBlazor is properly installed and configured.
* **Component Inheritance:**
    * All custom form field components inherit from a base component. This base component is assumed to provide common functionalities.
* **Error Handling:**
    * Basic error handling is implemented for JSON deserialization. More robust error handling may be required for production environments.
* **Value Storage:**
    * The FormField class contains a Value property of type object. This property is used to store the value of the field. It is the responsiblity of the implementation to cast this object to the correct type.

## Getting Started

1.  **Clone the Repository:**
    ```bash
    git clone [your-repository-url]
    cd [your-project-directory]
    ```

2.  **Install Dependencies:**
    * Ensure you have the .NET SDK installed.
    * Restore NuGet packages:
        ```bash
        dotnet restore
        ```

3.  **Run the Application:**
    ```bash
    dotnet run --project [your-project-name].csproj
    ```

4.  **Access the Application:**
    * Open your browser and navigate to the URL displayed in the console (e.g., `https://localhost:5001`).

## JSON Configuration Example

```json
{
  "title": "Sample Form",
  "fields": [
    {
      "type": "text",
      "label": "Name"
    },
    {
      "type": "email",
      "label": "Email",
      "required": true
    },
    {
      "type": "date",
      "label": "BirthDate",
      "required": true
    },
    {
      "type": "time",
      "label": "BirthTime",
      "required": true
    },
    {
      "type": "number",
      "label": "Age",
      "min": 18,
      "max": 100
    },
    {
      "type": "dropdown",
      "label": "Industry",
      "values": [ "Tech", "Production", "Health" ],
      "required": true
    },
    {
      "type": "radio",
      "label": "Industry Radio",
      "values": [ "Tech", "Production", "Health" ],
      "required": true
    },
    {
      "type": "checkbox",
      "label": "Subscribe to Newsletter",
      "required": false
    }
  ]
}
