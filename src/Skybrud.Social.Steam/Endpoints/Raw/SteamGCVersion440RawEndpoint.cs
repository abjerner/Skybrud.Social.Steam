using Skybrud.Social.Http;
using Skybrud.Social.Steam.OAuth;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the gc version 440 endpoint.
    /// </summary>
    public class SteamGCVersion440RawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal SteamGCVersion440RawEndpoint(SteamOAuthClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SocialHttpResponse GetClientVersion()
        {
            return Client.DoHttpGetRequest("/IGCVersion_440/GetClientVersion/v1/");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SocialHttpResponse GetServerVersion()
        {
            return Client.DoHttpGetRequest("/IGCVersion_440/GetServerVersion/v1/");
        }

        #endregion

    }
}
