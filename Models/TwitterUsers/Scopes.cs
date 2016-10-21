using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public class Scopes
    {
        public virtual bool followers { get; set; }
    }
}