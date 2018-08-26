using Skybrud.Social.Http;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the gc version 570 endpoint.
    /// </summary>
    public class SteamGCVersion570RawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamHttpClient Client { get; }

        #endregion

        #region Constructors

        internal SteamGCVersion570RawEndpoint(SteamHttpClient client)
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
            return Client.DoHttpGetRequest("/IGCVersion_570/GetClientVersion/v1/");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SocialHttpResponse GetServerVersion()
        {
            return Client.DoHttpGetRequest("/IGCVersion_570/GetServerVersion/v1/");
        }

        #endregion

    }
}
