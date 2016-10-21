using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Twitter24.Models;
using System.Configuration;

namespace Twitter24.Services
{
    /* Basic DelegatingHandler that creates an OAuth authorization header based on the OAuthBase 
     * Class downloaded from http://oauth.net */
    public class OAuthMessageHandler : DelegatingHandler
    {

        /* Twitter OAuth values are stored in TwitterSettings.config. */

        /* Retrieve consumer key */
        private static string _consumerKey = ConfigurationManager.AppSettings["consumerkey"].ToString();

        /* Retrieve consumer secret */
        private static string _consumerSecret = ConfigurationManager.AppSettings["consumersecret"].ToString();

        /* Retrieve access token */
        private static string _token = ConfigurationManager.AppSettings["accesstoken"].ToString();

        /* Retrieve access secret */
        private static string _tokenSecret = ConfigurationManager.AppSettings["accesssecret"].ToString();

        private OAuthBase _oAuthBase = new OAuthBase();

        public OAuthMessageHandler(HttpMessageHandler innerHandler)
            : base(innerHandler)
        {
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            /* Compute OAuth header */
            string normalizedUri;
            string normalizedParameters;
            string authHeader;

            string signature = _oAuthBase.GenerateSignature(request.RequestUri, _consumerKey, _consumerSecret, _token, _tokenSecret, request.Method.Method, _oAuthBase.GenerateTimeStamp(), _oAuthBase.GenerateNonce(), out normalizedUri, out normalizedParameters, out authHeader);

            request.Headers.Authorization = new AuthenticationHeaderValue("OAuth", authHeader);
            return base.SendAsync(request, cancellationToken);
        }
    }
}