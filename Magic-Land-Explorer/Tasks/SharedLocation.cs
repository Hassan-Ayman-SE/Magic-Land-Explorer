using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public static class SharedLocation
    {
        public static void ShowSharedLocations(List<Category> categories)
        {
            var sharedLocations = categories
                .SelectMany(c => c.Destinations)
                .Where(d => d.Location == "Fantasyland")
                .Select(d => d.Name);

            Console.WriteLine("Destinations in Fantasyland:");
            foreach (var name in sharedLocations)
            {
                Console.WriteLine(name);
            }
        }
    }
}
