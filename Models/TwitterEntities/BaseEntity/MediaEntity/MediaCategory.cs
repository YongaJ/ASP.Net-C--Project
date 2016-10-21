using Newtonsoft.Json;

namespace Twitter24.Models
{
    [JsonObject]
    public class MediaCategory
    {
        private MediaCategory()
        {
        }

        public const string Image = "tweet_image";
        public const string AnimatedGif = "tweet_gif";
        public const string Video = "tweet_video";
    }
}