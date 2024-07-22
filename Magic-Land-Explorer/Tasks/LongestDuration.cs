using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public static class LongestDuration
    {
        public static void ShowLongestDurationDestination(List<Category> categories)
        {
            var longestDurationDestination = categories
                .SelectMany(c => c.Destinations)
                .OrderByDescending(d => d.Duration)
                .FirstOrDefault();

            Console.WriteLine("Destination with the longest duration:");
            if (longestDurationDestination != null)
            {
                Console.WriteLine(longestDurationDestination.Name);
            }
        }
    }
}
