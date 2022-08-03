using Newtonsoft.Json;
using System.Collections.Generic;

namespace WordsAPI.Models
{
    public class WordData
    {
        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("definitions")]
        public List<DefinitionData> Definitions { get; set; }

        [JsonProperty("synonyms")]
        public List<string> Synonyms { get; set; }

        [JsonProperty("examples")]
        public List<string> Examples { get; set; }

        [JsonProperty("rhymes")]
        public RhymesData Rhymes { get; set; }

        [JsonProperty("antonymns")]
        public List<string> Antonymns { get; set; }
    }
}