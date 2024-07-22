using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public static class SortByName
    {
        public static void ShowSortedDestinations(List<Category> categories)
        {
            var sortedDestinations = categories
                .SelectMany(c => c.Destinations)
                .OrderBy(d => d.Name);

            Console.WriteLine("Destinations sorted alphabetically by name:");
            foreach (var destination in sortedDestinations)
            {
                Console.WriteLine(destination.Name);
            }
        }
    }
}
