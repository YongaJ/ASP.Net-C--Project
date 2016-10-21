using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Twitter24.Models
{
    [JsonObject]
    public class PlacesAttributes
    {
        public virtual string street_address { get; set; }

        /* The city the place is in */
        public virtual string locality { get; set; }

        /* The administrative region the place is in */
        public virtual string region { get; set; }

        /* The country code */
        public virtual string iso3 { get; set; }

        /* In the preferred local format for the place */
        public virtual string postal_code { get; set; }

        /* In the preferred local format for the place, include long distance code */
        public virtual string phone { get; set; }

        /* Twitter screen-name, without @ */
        public virtual string twitter { get; set; }

        /* Official/canonical URL for place */
        public virtual Uri url { get; set; } //uri

        /* An ID or comma separated list of IDs representing the place in the applications place database. */
        public IList<string> app_id { get; set; }
    }
}
 
 
 
 
 
 
 
 