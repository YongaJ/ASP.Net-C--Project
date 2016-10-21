using Newtonsoft.Json;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public class ExtendedEntities : ExtendedEntity
    { 
        public virtual IList<ExtendedEntity> media { get; set; }

        public ExtendedEntities()
        {
            Initialize();
        }

        private void Initialize()
        {
            media = new List<ExtendedEntity>(0);
        }        
    }
}
 
 
 
 
 
 
 