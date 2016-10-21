using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public class Hashtags : Entity
    {
        /* Name of the hashtag, minus the leading ‘#’ character. */
        public virtual string text { get; set; }

        public override Enums.EntityType entity_type { get; protected set; }

        public Hashtags()
        {
            Initialize();
        }

        private void Initialize()
        {
            entity_type = Enums.EntityType.Hashtag;
        }

    }
}
 
 