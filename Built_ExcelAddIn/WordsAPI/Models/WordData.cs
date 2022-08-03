using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace WordsAPI.Models
{
    public class WordData
    {
        [JsonProperty("name")]
        public string Word { get; set; }

        [JsonProperty("definitions")]
        public List<DefinitionData> Definitions { get; set; }
    }
}
