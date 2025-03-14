# Blazor Dynamic Form Generator

This project is a Blazor WebAssembly application designed to generate forms based on JSON configuration files dynamically. It leverages MudBlazor to enhance UI and user experience.

## Project Overview

This application reads form field configurations from JSON files located in `wwwroot/sample-data`. Each JSON file defines the structure and properties of a form, allowing for flexible and dynamic form creation.

## Features

* **Dynamic Form Generation:** Forms are generated based on JSON configuration, allowing for easy updates and modifications without recompiling.
* **Component-Based Architecture:** Each field type (text, email, number, dropdown, checkbox, date, time, radio) is implemented as a separate component for easy maintenance and debugging.
* **MudBlazor Integration:** Utilizes MudBlazor for a modern and responsive user interface.
* **Base Component Wrapper:** All field components inherit from a base component, providing a consistent interface and reducing code duplication.
* **Customizable Field Options:** Dropdown and radio components support options read directly from the JSON configuration.
* **JSON Output Display:** After submitting the form, the final JSON output representing the collected form data will be displayed below the form.

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
              "values": [],
            },
            // ... more fields
          ]
        }
        ```
    * The `type` field can be (text, email, number, dropdown, checkbox, date, time, radio).
* **Data Types:**
    * Number fields expect integer values.
* **MudBlazor:**
    * The project relies on the MudBlazor library for UI components. Ensure MudBlazor is properly installed and configured.
* **Component Inheritance:**
    * All custom form field components inherit from a base component. This base component is assumed to provide common functionalities.
* **Error Handling:**
    * Basic error handling is implemented for JSON deserialization. More robust error handling may be required for production environments.

## Getting Started

1.  **Clone the Repository:**
    ```bash
    git clone https://github.com/ali-akhound/FormGenerator.git
    cd FormGenerator
    ```

2.  **Install Dependencies:**
    * Ensure you have the .NET 8 SDK installed.
    * Restore NuGet packages:
        ```bash
        dotnet restore
        ```

3.  **Run the Application:**
    ```bash
    dotnet run --project FormGenerator.csproj
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
      "type": "checkbox",
      "label": "Subscribe to Newsletter",
      "required": false
    },
    {
      "type": "radio",
      "label": "Visa Status",
      "values": [ "PR", "Citizen", "Work Permit" ],
      "required": true
    }
  ]
}
