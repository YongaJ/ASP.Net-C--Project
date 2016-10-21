using Newtonsoft.Json;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public class BoundingBox
    {
        /* A series of longitude and latitude points, defining a box which will contain the Place entity this bounding box is related to.
         * Each point is an array in the form of [longitude, latitude]. 
         * Points are grouped into an array per bounding box. 
         * Bounding box arrays are wrapped in one additional array to be compatible with the polygon notation. */
        public virtual IList<Coordinates> coordinates { get; set; }

        /* The type of data encoded in the coordinates property. This will be “Polygon” for bounding boxes. */
        public virtual string type { get; set; }
    }
}
 