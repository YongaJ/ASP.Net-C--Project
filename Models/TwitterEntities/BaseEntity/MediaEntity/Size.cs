using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public class Size
    {
        /* Height in pixels of this size. */
        public virtual int h { get; set; }

        /* Resizing method used to obtain this size. 
         * A value of fit means that the media was resized to fit one dimension, keeping its native aspect ratio.
         * A value of crop means that the media was cropped in order to fit a specific resolution. */
        public virtual string resize { get; set; }

        /* Width in pixels of this size. */
        public virtual int w { get; set; }
    }
}
 
 