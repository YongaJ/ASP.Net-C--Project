using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public class Tweets 
    {
        /* Nullable
         * A collection of brief user objects (usually only one) indicating users who contributed to the authorship of the tweet. */
        public virtual IList<Contributors> contributors { get; set; }

        /* Nullable.
         * Represents geographic location of this Tweet as reported by the user or client application. 
         * The inner coordinates array is formatted as geoJSON (longitude first, then latitude). */
        public virtual Coordinates coordinates { get; set; }

        /* UTC time when this Tweet was created. */
        public virtual string created_at { get; set; } //DateTime

        /* Entities which have been parsed out of the text of the Tweet.  */
        public virtual Entities entities { get; set; }

        /* Nullable. 
         * Indicates approximately how many times this Tweet has been “liked” by Twitter users. */
        public virtual int? favorite_count { get; set; }

        /* Nullable. 
         * Perspectival. 
         * Indicates whether this Tweet has been liked by the authenticating user. */
        public virtual bool? favorited { get; set; }

        /* The integer representation of the unique identifier for this Tweet; greater than 53 bits. */
        public virtual long? id { get; set; }

        /* The string representation of the unique identifier for this Tweet. 
         * Implementations should use this rather than the large integer in id. */
        public virtual string id_str { get; set; }

        /* Nullable. 
         * If the represented Tweet is a reply, this field will contain the screen name of the original Tweet’s author. */
        public virtual string in_reply_to_screen_name { get; set; }

        /* Nullable. 
         * If the represented Tweet is a reply, this field will contain the integer representation of the original Tweet’s ID. */
        public virtual long? in_reply_to_status_id { get; set; } //long

        /* Nullable. 
         * If the represented Tweet is a reply, this field will contain the string representation of the original Tweet’s ID. */
        public virtual string in_reply_to_status_id_str { get; set; }

        /* Nullable. 
         * If the represented Tweet is a reply, this field will contain the integer representation of the original Tweet’s author ID. 
         * This will not necessarily always be the user directly mentioned in the Tweet. */
        public virtual long? in_reply_to_user_id { get; set; }

        /* Nullable. 
         * If the represented Tweet is a reply, this field will contain the string representation of the original Tweet’s author ID. 
         * This will not necessarily always be the user directly mentioned in the Tweet. */
        public virtual string in_reply_to_user_id_str { get; set; }

        /* Nullable. 
         * When present, indicates a BCP 47 language identifier corresponding to the machine-detected language of the Tweet text, or “und” if no language could be detected. */
        public virtual string lang { get; set; }

        /* Nullable. 
         * This field only surfaces when a tweet contains a link. 
         * The meaning of the field doesn’t pertain to the tweet content itself, but instead it is an indicator that the URL contained in the tweet may contain content or media identified as sensitive content.  */
        public virtual bool? possibly_sensitive { get; set; }

        /* This field only surfaces when the Tweet is a quote Tweet. 
         * This field contains the integer value Tweet ID of the quoted Tweet. */
        public virtual long? quoted_status_id { get; set; } //long

        /* This field only surfaces when the Tweet is a quote Tweet. 
         * This is the string representation Tweet ID of the quoted Tweet. */
        public virtual string quoted_status_id_str { get; set; }

        /* Number of times this Tweet has been retweeted. 
         * This field is no longer capped at 99 and will not turn into a String for “100+” */
        public virtual int retweet_count { get; set; }

        /* Perspectival. 
         * Indicates whether this Tweet has been retweeted by the authenticating user. */
        public virtual bool retweeted { get; set; }

        /* Utility used to post the Tweet, as an HTML-formatted string. 
         * Tweets from the Twitter website have a source value of web. */
        public virtual string source { get; set; }

        /* The actual UTF-8 text of the status update. 
         * See twitter-text for details on what is currently considered valid characters. */
        public virtual string text { get; set; } //jsonproperty?

        /* Indicates whether the value of the text parameter was truncated, for example, as a result of a retweet exceeding the 140 character Tweet length. 
         * Twitter rejects long Tweets vs truncating them, the large majority of Tweets will have this set to false. */
        public virtual bool truncated { get; set; }

        /* The user who posted this Tweet. */
        public virtual Users user { get; set; }
    }
}