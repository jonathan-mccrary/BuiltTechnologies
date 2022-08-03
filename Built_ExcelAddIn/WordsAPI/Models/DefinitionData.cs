using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
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
