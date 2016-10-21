using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public abstract class AspectRatio
    {
        public int h { get; set; }
        public int w { get; set; }
    }
}