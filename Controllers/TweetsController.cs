using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Twitter24.Models;
using Twitter24.Services;

namespace Twitter24.Controllers
{
    public class TweetsController : ApiController
    {
        private TwitterRestService _TwitterRestService;

        public TweetsController()
        {
            this._TwitterRestService = new TwitterRestService();
        }
        public async Task<List<Tweets>> GetTweets()
        {
            return await this._TwitterRestService.GetUserTimeline();
        }
        
    }
}
