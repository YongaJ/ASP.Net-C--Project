using Newtonsoft.Json;
using System;

namespace Twitter24.Models
{
    [JsonObject]
    public class MediaVariant
    {
        public virtual long bitRate { get; set; }
        public virtual string content_type { get; set; }
        public virtual Uri url { get; set; }
    }
}