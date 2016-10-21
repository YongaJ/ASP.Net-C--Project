using System.Collections.Generic;
using Newtonsoft.Json;


namespace Twitter24.Models
{
    [JsonObject]
    public class ProfileBanners
    {
        public virtual IDictionary<string, ProfileBannerSizes> sizes { get; set; }
        
    }
}