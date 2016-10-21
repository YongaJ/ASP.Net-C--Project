using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public class UserMention : Entity
    {
        /* ID of the mentioned user, as an integer. */
        public virtual long id { get; set; }

        /* If of the mentioned user, as a string. */
        public virtual string id_str { get; set; }

        /* Display name of the referenced user. */
        public virtual string name { get; set; }

        /* Screen name of the referenced user. */
        public virtual string screen_name { get; set; }

        public override Enums.EntityType entity_type { get; protected set; }

        public UserMention()
        {
            entity_type = Enums.EntityType.UserMention;
        }
    }
}