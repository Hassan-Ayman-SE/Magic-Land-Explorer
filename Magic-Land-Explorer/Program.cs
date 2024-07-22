using Magic_Land_Explorer.Tasks;
using Newtonsoft.Json;

namespace Magic_Land_Explorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
            string jsonFilePath = Path.Combine(dataDirectory, "MagicLandData.json");

            if (!File.Exists(jsonFilePath))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The MagicLandData.json file could not be found: " + jsonFilePath);
                Console.ResetColor();
                return;
            }

            string json = File.ReadAllText(jsonFilePath);
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new TimeSpanConverter());
            List<Category>? categories = JsonConvert.DeserializeObject<List<Category>>(json, settings);


            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1- Show filtered destinations");
                Console.WriteLine("2- Show longest duration destination");
                Console.WriteLine("3- Sort destinations by name");
                Console.WriteLine("4- Show top 3 longest durations");
                Console.WriteLine("5- Show destinations in Fantasyland");
                Console.WriteLine("6- Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        FilterDestinations.ShowFilteredDestinations(categories);
                        break;
                    case "2":
                        LongestDuration.ShowLongestDurationDestination(categories);
                        break;
                    case "3":
                        SortByName.ShowSortedDestinations(categories);
                        break;
                    case "4":
                        Top3Duration.ShowTop3Durations(categories);
                        break;
                    case "5":
                        SharedLocation.ShowSharedLocations(categories);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}
