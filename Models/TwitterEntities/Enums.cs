using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public class Enums
    {
        public enum SearchResultType
        {
            Mixed,
            Recent,
            Popular
        }

        public enum ProfileImageSize
        {
            Bigger,
            Normal,
            Mini
        }

        public enum EntityType
        {
            Hashtag,
            UserMention,
            URL,
            Media
        }

        public enum PlaceType
        {
            City,
            Neighborhood,
            Country,
            Admin,
            POI
        }

        public enum MediaType
        {
            Photo,
            Video,
            AnimatedGif
        }

        public enum ListMode
        {
            Public,
            Private
        }
    }
}