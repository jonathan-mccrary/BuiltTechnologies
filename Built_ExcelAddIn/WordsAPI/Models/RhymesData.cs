using Newtonsoft.Json;
using System.Collections.Generic;

namespace WordsAPI.Models
{
    public class RhymesData
    {
        [JsonProperty("all")]
        public List<string> AllRhymes { get; set; }
    }
}