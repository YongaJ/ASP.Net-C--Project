using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public class CurrentUserRetweet
    {
        public virtual long? id { get; set; }
        public virtual string id_str { get; set; }
    }
}