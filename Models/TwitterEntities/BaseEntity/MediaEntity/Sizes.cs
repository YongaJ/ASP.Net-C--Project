using Newtonsoft.Json;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public class Sizes
    {
        /* Information for a thumbnail-sized version of the media. */
        public virtual IList<Size> thumb { get; set; } //thumb- object

        /* Information for a large-sized version of the media. */
        public virtual IList<Size> large { get; set; }

        /* Information for a medium-sized version of the media. */
        [JsonIgnore]
        public virtual IList<Size> medium { get; set; }

        /* Information for a small-sized version of the media. */
        public virtual IList<Size> small { get; set; }
    }
}
 
 
 