using Skybrud.Social.Http;
using Skybrud.Social.Steam.OAuth;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the Steam web api endpoint.
    /// </summary>
    public class SteamWebAPIUtilRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal SteamWebAPIUtilRawEndpoint(SteamOAuthClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SocialHttpResponse GetServerInfo()
        {
            return Client.DoHttpGetRequest("/ISteamWebAPIUtil/GetServerInfo/v1/");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SocialHttpResponse GetSupportedAPIList()
        {
            return Client.DoHttpGetRequest("/ISteamWebAPIUtil/GetSupportedAPIList/v1/");
        }

        #endregion

    }
}
