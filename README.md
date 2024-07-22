# Magic Land Explorer

## Problem Domain
This console application simulates exploring various destinations within Magic Land. The application reads data from an external JSON file containing information about different destinations, rides, shows, and dining options in the park. Users can interactively explore the available categories and destinations and view details about specific features using LINQ queries and delegates.

## Program Specifications
- **Read JSON Data:** The application reads data from a JSON file using `Newtonsoft.Json`.
- **Parse JSON Data:** The JSON data is parsed into C# objects.
- **LINQ Queries:** LINQ queries and lambda expressions are used to manipulate and filter the data.
- **Interactive Console Interface:** Users can interact with the application through a console interface to perform various tasks.
- **Delegates:** Delegates handle user interactions and display information.
- **Error Handling:** The application handles errors such as invalid user inputs or missing data.

## Steps
1. **Project Setup:**
    - Create a new C# console application.
    - Add `Category.cs`, `Destination.cs`, and other task files.
    - Install `Newtonsoft.Json`.
    - Add the JSON file to a `data` folder.

2. **Define Classes for JSON Data:**
    - `Destination.cs` defines properties for destinations.
    - `Category.cs` defines properties for categories.

3. **LINQ Query Tasks:**
    - `FilterDestinations.cs` finds destinations with a duration less than 100 minutes.
    - `LongestDuration.cs` finds the destination with the longest duration.
    - `SortByName.cs` sorts destinations alphabetically by name.
    - `Top3Duration.cs` finds the top three longest-duration destinations.

4. **Interactive Console Interface:**
    - `Program.cs` provides an interface for users to interact with the application and perform LINQ queries.

## Stretch Goals
- `SharedLocation.cs` finds and lists all categories that have "Fantasyland" as a shared location.

## Usage
1. Run the application.
2. Choose an option from the menu to perform various tasks.
3. View the results of the chosen LINQ query.

## JSON Data
The application reads data from `MagicLandData.json` which contains information about various destinations in Magic Land.

## Installation
- Ensure you have .NET installed.
