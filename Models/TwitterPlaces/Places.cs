using Newtonsoft.Json;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public class Places 
    {
        /* Contains a hash of variant information about the place. See Place Attributes for more detail. */
        public virtual IList<PlacesAttributes> attributes { get; set; }

        /* A bounding box of coordinates which encloses this place. */
        public virtual IList<BoundingBox> coordinates { get; set; }

        /* Name of the country containing this place. */
        public virtual string country { get; set; }

        /* Shortened country code representing the country containing this place. */
        public virtual string country_code { get; set; }

        /* Full human-readable representation of the place’s name. */
        public virtual string full_name { get; set; }

        /* ID representing this place. Note that this is represented as a string, not an integer */
        public virtual string id { get; set; }

        /* Short human-readable representation of the place’s name. */
        public virtual string name { get; set; }

        /* The type of location represented by this place. */
        public virtual string place_type { get; set; }

        /* URL representing the location of additional place metadata for this place. */
        public virtual string url { get; set; }
    }
}
 
 
 
 
 
 
 
 