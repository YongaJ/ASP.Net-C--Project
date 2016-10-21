using System.Collections.Generic;
using Newtonsoft.Json;


namespace Twitter24.Models
{
    [JsonObject]
    public class Users
    {
        /* Indicates that the user has an account with “contributor mode” enabled, allowing for Tweets issued by the user to be co-authored by another account. */
        public virtual bool? contributers_enabled { get; set; }

        /* The UTC datetime that the user account was created on Twitter.  */
        public virtual string created_at { get; set; } //datetime

        /* When true, indicates that the user has not altered the theme or background of their user profile. */
        public virtual bool default_profile { get; set; }

        /* When true, indicates that the user has not uploaded their own avatar and a default egg avatar is used instead. */
        public virtual bool default_profile_image { get; set; }

        /* Nullable. 
         * The user-defined UTF-8 string describing their account. */
        public virtual string description { get; set; }

        /** Entities which have been parsed out of the url or description fields defined by the user. */
        public virtual Entities entities { get; set; }

        /* The number of tweets this user has favorited in the account’s lifetime.  */
        public virtual int favourites_count { get; set; }

        /* Nullable. 
         * Perspectival. 
         * When true, indicates that the authenticating user has issued a follow request to this protected user account. */
        public virtual bool? follow_request_sent { get; set; } //Type

        /* The number of followers this account currently has. */
        public virtual int followers_count { get; set; }

        /** The number of users this account is following (AKA their “followings”). */
        public virtual int friends_count { get; set; }

        /** When true, indicates that the user has enabled the possibility of geotagging their Tweets. */
        public virtual bool geo_enabled { get; set; }

        public virtual long id { get; set; }

        /* The string representation of the unique identifier for this User. */
        public virtual string id_str { get; set; }

        /* When true, indicates that the user is a participant in Twitter’s translator community. */
        public virtual bool? is_translator { get; set; }

        /* The BCP 47 code for the user’s self-declared user interface language. 
         * May or may not have anything to do with the content of their Tweets. */
        public virtual string lang { get; set; }

        /* The number of public lists that this user is a member of. */
        public virtual int listed_count { get; set; }

        /* Nullable. 
         * The user-defined location for this account’s profile. 
         * Not necessarily a location nor parseable.  */
        public virtual string location { get; set; }

        /* The name of the user, as they’ve defined it. 
         * Not necessarily a person’s name. */
        public virtual string name { get; set; }

        /* The hexadecimal color chosen by the user for their background. */
        public virtual string profile_background_color { get; set; }

        /* A HTTP-based URL pointing to the background image the user has uploaded for their profile. */
        public virtual string profile_background_image_url { get; set; }

        /* A HTTPS-based URL pointing to the background image the user has uploaded for their profile. */
        public virtual string profile_background_image_url_https { get; set; }

        /* When true, indicates that the user’s profile_background_image_url should be tiled when displayed. */
        public virtual bool profile_background_tile { get; set; }

        /* The HTTPS-based URL pointing to the standard web representation of the user’s uploaded profile banner. */
        public virtual string profile_banner_url { get; set; }

        /* A HTTP-based URL pointing to the user’s avatar image. */
        public virtual string profile_image_url_http { get; set; }

        /* A HTTPS-based URL pointing to the user’s avatar image */
        public string profile_image_url_https { get; set; }

        /* The hexadecimal color the user has chosen to display links with in their Twitter UI. */
        public virtual string profile_link_color { get; set; }

        /* The hexadecimal color the user has chosen to display sidebar borders with in their Twitter UI. */
        public virtual string profile_sidebar_border_color { get; set; }

        /* The hexadecimal color the user has chosen to display sidebar backgrounds with in their Twitter UI. */
        public virtual string profile_sidebar_fill_color { get; set; }

        /* The hexadecimal color the user has chosen to display text with in their Twitter UI. */
        public virtual string profile_text_color { get; set; }

        /* When true, indicates the user wants their uploaded background image to be used */
        public virtual bool profile_use_background_image { get; set; }

        /* When true, indicates that this user has chosen to protect their Tweets. */
        public virtual bool? _protected { get; set; } //bool

        /* The screen name, handle, or alias that this user identifies themselves with. 
         * screen_names are unique but subject to change. 
         * Use id_str as a user identifier whenever possible. */
        public virtual string screen_name { get; set; }

        /* Indicates that the user would like to see media inline. */
        public virtual bool show_all_inline_media { get; set; }

        /* Nullable. 
         * If possible, the user’s most recent tweet or retweet. 
         * In some circumstances, this data cannot be provided and this field will be omitted, null, or empty. 
         * Perspectival attributes within tweets embedded within users cannot always be relied upon. */
        public virtual IList<Tweets> status { get; set; }

        /* The number of tweets (including retweets) issued by the user. */
        public virtual int statuses_count { get; set; }

        /* Nullable. A
         *  string describing the Time Zone this user declares themselves within. */
        public virtual string time_zone { get; set; }

        /* Nullable. 
         * A URL provided by the user in association with their profile. */
        public virtual string url { get; set; }

        /* Nullable. 
         * The offset from GMT/UTC in seconds. */
        public virtual int? utc_offset { get; set; }

        /* When true, indicates that the user has a verified account. */
        public virtual bool verified { get; set; }

        /* When present, indicates a textual representation of the two-letter country codes this user is withheld from. */
        public virtual IList<string> withheld_in_countries { get; set; }

        /* When present, indicates whether the content being withheld is the “status” or a “user.” */
        public virtual string withheld_scope { get; set; }
    }
}