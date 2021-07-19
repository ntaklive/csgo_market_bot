using System.Collections.Generic;
using Newtonsoft.Json;

namespace FloatTool.Models.Responses
{
    public class ParserScriptResponse
    {
        [JsonProperty("links")]
        public List<string> Links { get; set; }

        [JsonProperty("prices")]
        public List<double?> Prices { get; set; }

        [JsonProperty("idlist")]
        public List<long> IdList { get; set; }
    }
}
