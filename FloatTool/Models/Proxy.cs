using Newtonsoft.Json;

namespace FloatTool.Models
{
    public sealed class Proxy
    {
        [JsonIgnore]
        public bool IsUsed { get; set; }
        public string Ip { get; set; }
        public int? Port { get; set; }

        public override string ToString()
        {
            return $"{Ip}:{Port}"; // Unexpected situation when Port is null
        }
    }
}