using Newtonsoft.Json;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public class Coordinates
    {
        /* The longitude and latitude of the Tweet’s location, as an collection in the form of [longitude, latitude]. */
        public virtual IList<float> cooardinates { get; set; }

        /* The type of data encoded in the coordinates property. 
         * This will be “Point” for Tweet coordinates fields. */
        public virtual string type { get; set; } 
    }
}