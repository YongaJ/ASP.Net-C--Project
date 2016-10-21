using Newtonsoft.Json;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public abstract class Entity
    {
        /* An array of integers indicating the offsets within the Tweet text where the hashtag begins and ends. 
         * The first integer represents the location of the # character in the Tweet text string. 
         * The second integer represents the location of the first character after the hashtag. 
         * Therefore the difference between the two numbers will be the length of the hashtag name plus one (for the ‘#’ character). */
        public virtual IList<int> indices { get; set; }

        public virtual Enums.EntityType entity_type { get; protected set; }

    }
}