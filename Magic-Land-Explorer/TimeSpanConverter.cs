using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer
{

    public class TimeSpanConverter : JsonConverter<TimeSpan>
    {
        public override TimeSpan ReadJson(JsonReader reader, Type objectType, TimeSpan existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            string durationString = (string)reader.Value;
            if (durationString.EndsWith(" minutes"))
            {
                int minutes = int.Parse(durationString.Replace(" minutes", ""));
                return TimeSpan.FromMinutes(minutes);
            }
            throw new JsonSerializationException("Invalid duration format");
        }

        public override void WriteJson(JsonWriter writer, TimeSpan value, JsonSerializer serializer)
        {
            writer.WriteValue($"{value.TotalMinutes} minutes");
        }
    }

}
