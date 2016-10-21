using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public class URL : Entity
    {
        /* Version of the URL to display to clients. */
        public virtual string display_url { get; set; }

        /* Expanded version of display_url. */
        public virtual string expanded_url { get; set; }

        /* Wrapped URL, corresponding to the value embedded directly into the raw Tweet text, and the values for the indices parameter */
        public virtual string url { get; set; }

        public override Enums.EntityType entity_type { get; protected set; }

        public URL()
        {
            Initialize();
        }

        private void Initialize()
        {
            entity_type = Enums.EntityType.URL;
        }
    }
}
 
 
 
 