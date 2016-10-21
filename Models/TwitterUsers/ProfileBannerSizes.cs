using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public class ProfileBannerSizes
    {
        public virtual int h { get; set; }
        public virtual int w { get; set; }
        public virtual int url { get; set; }
    }
}