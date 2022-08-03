using Newtonsoft.Json;

namespace WordsAPI.Models
{
    public class DefinitionData
    {
        [JsonProperty("definition")]
        public string Definition { get; set; }

        [JsonProperty("partOfSpeech")]
        public string PartOfSpeech { get; set; }
    }
}