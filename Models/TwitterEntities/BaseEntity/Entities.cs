using Newtonsoft.Json;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public class Entities : Entity
    {
        /* Represents hashtags which have been parsed out of the Tweet text. */
        public virtual IList<Hashtags> hashtags { get; set; }

        /* Represents media elements uploaded with the Tweet. */
        public virtual IList<Media> media { get; set; }

        /* Represents URLs included in the text of a Tweet or within textual fields of a user object. */
        public virtual IList<URL> urls { get; set; }

        /* Represents other Twitter users mentioned in the text of the Tweet. */
        public virtual IList<UserMention> user_mentions { get; set; }
        
    }
}
 
 
 