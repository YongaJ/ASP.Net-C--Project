using Newtonsoft.Json;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public class VideoInfo
    {
        public virtual IList<int> aspect_ratio { get; set; }

        public virtual long duration_millis { get; set; }

        public virtual IList<MediaVariant> variants { get; set; }
    }
}