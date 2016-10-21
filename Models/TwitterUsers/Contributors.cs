using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public class Contributors
    {
        /* The integer representation of the ID of the user who contributed to this Tweet. */
        public virtual long id { get; set; }

        /* The string representation of the ID of the user who contributed to this Tweet. */
        public virtual string id_str { get; set; }

        /* The screen name of the user who contributed to this Tweet. */
        public virtual string screen_name { get; set; } 
    }
}