using Newtonsoft.Json;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public class Symbols
    {
        public virtual string symbol { get; set; }

        public virtual IList<int> indices { get; set; }
    }
}
 