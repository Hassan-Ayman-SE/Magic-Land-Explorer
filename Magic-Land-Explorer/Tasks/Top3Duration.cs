using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public static class Top3Duration
    {
        public static void ShowTop3Durations(List<Category> categories)
        {
            var top3Durations = categories
                .SelectMany(c => c.Destinations)
                .OrderByDescending(d => d.Duration)
                .Take(3)
                .Select(d => new { d.Name, d.Duration });

            Console.WriteLine("Top 3 longest-duration destinations:");
            foreach (var item in top3Durations)
            {
                Console.WriteLine($"{item.Name} - {item.Duration} minutes");
            }
        }
    }
}
