using Newtonsoft.Json;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public class Media : Entity
    {

        /* Not a URL but a string to display instead of the media URL. */
        public virtual string display_url { get; set; }

        /* The fully resolved media URL. */
        public virtual string expanded_url { get; set; }

        /* The media ID (int format). */
        public virtual long id { get; set; }

        /* The media ID (string format). */   
        public virtual string id_str { get; set; } //int

        /* The character positions the media was extracted from */
        public override IList<int> indices { get; set; }

        /* The URL of the media file. */
        public virtual string media_url { get; set; }

        /* The SSL URL of the media file. */
        public virtual string media_url_https { get; set; }

        /* Sizes: thumb, small, medium and large. 
         * The media_url defaults to medium but you can retrieve the media in different sizes by appending a colon + the size key.
         * Each available size comes with three attributes that describe it: 
         * w: the width (in pixels) of the media in this particular size 
         * h: the height (in pixels) of the media in this particular size resize: 
         * How we resized the media to this particular size (can be crop or fit) */
        [JsonIgnore]
        public virtual IList<Sizes> sizes { get; set; }

        /* For Tweets containing media that was originally associated with a different tweet, this ID points to the original Tweet. */
        public virtual long source_status_id { get; set; } 

        /* For Tweets containing media that was originally associated with a different tweet, this string-based ID points to the original Tweet. */
        public virtual string source_status_id_str { get; set; } 

        public override Enums.EntityType entity_type { get; protected set; } //photo

        /* The media URL that was extracted */
        public virtual string url { get; set; } //url?

        public Media()
        {
            Initialize();
        }

        private void Initialize()
        {
            entity_type = Enums.EntityType.Media;
        }
    }
}
 
 
 
 
 
 
 
 
 