using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Twitter24.Models;

namespace Twitter24.Services
{
    public class TwitterRestService
    {
        private static string _address = "https://api.twitter.com/1.1/statuses/user_timeline.json?include_rts=true&screen_name=News24&count=20";

        public Tweets _SingleTweet { get; set; }
        public List<Tweets> _Tweets { get; set; }

        public async Task<List<Tweets>> GetUserTimeline()
        {
            /* initialize with 0 item */
            _Tweets = new List<Tweets>();

            /* Create client and insert an OAuth message handler in the message path that inserts an OAuth authentication header in the request. */
            HttpClient client = new HttpClient(new OAuthMessageHandler(new HttpClientHandler()));

            /* Send asynchronous request to twitter and read the response as JToken */
            HttpResponseMessage response = await client.GetAsync(_address);

            if (response.IsSuccessStatusCode)
            {

                JToken _TwitterFeed = await response.Content.ReadAsAsync<JToken>();
                foreach (var tweet in _TwitterFeed)
                {
                    /* Deserialization token */
                    _SingleTweet = tweet.ToObject<Tweets>();

                    /* Add a new item at the end of the list */
                    _Tweets.Add(_SingleTweet);

                }
            }
            return _Tweets;
        }

    }

    
}