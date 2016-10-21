using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public class ExtendedEntity : Entity
    {
        public ExtendedEntity()
        {
            base.entity_type = Enums.EntityType.Media;
        }

        /* the media ID (int format) */
        public virtual int id { get; set; }

        /* the media ID (string format) */
        public virtual string id_str { get; set; }

        /* The URL of the media file */
        public virtual Uri media_url { get; set; } //url?

        /* The SSL URL of the media file */
        public virtual Uri media_url_https { get; set; }

        /* The media URL that was extracted */
        public virtual Uri url { get; set; }

        /* Not a URL but a string to display instead of the media URL */
        public virtual Uri display_url { get; set; }

        /* The fully resolved media URL */
        public virtual Uri expanded_url { get; set; }

        /* Sizes: thumb, small, medium and large. 
         * The media_url defaults to medium but you can retrieve the media in different sizes by appending a colon + the size key.
         * Each available size comes with three attributes that describe it: 
         * w: the width (in pixels) of the media in this particular size 
         * h: the height (in pixels) of the media in this particular size resize: 
         * How we resized the media to this particular size (can be crop or fit) */
        public virtual IList<Sizes> sizes { get; set; }

        public virtual Enums.MediaType type { get; set; } //photo

        /* The character positions the media was extracted from */
        public override IList<int> indices { get; set; }

        /* Contains information about aspect ratio. 
         * The aspect ratio of the video, as a simplified fraction of width and height in a 2-element array. 
         * Typical values are [4, 3] or [16, 9]. 
         * This field is present only when there is a video in the payload. */
        public VideoInfo video_info { get; set; }

        /* The length of the video, in milliseconds. 
         * This field is present only when there is a video in the payload. */
        public virtual long duration_millis { get; set; }

        /* Different encodings/streams of the video. 
         * At least one variant is returned for each video entry. 
         * This field is present only when there is a video in the payload. */
        public virtual IList<MediaVariant> variants { get; set; }
    }
}