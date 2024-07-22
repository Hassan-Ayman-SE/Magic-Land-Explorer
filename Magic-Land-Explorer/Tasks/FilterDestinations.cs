using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public static class FilterDestinations
    {
        public static void ShowFilteredDestinations(List<Category> categories)
        {
            var filteredDestinations = categories
                .SelectMany(c => c.Destinations)
                .Where(d => d.Duration.TotalMinutes < 100)
                .Select(d => d.Name);

            Console.WriteLine("Destinations with a duration less than 100 minutes:");
            foreach (var name in filteredDestinations)
            {
                Console.WriteLine(name);
            }
        }
    }
}
