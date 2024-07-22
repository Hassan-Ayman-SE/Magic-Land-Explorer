using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer
{
    public class Destination
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Location { get; set; }

        [JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan Duration { get; set; }
        public string? Description { get; set; }
    }
}
