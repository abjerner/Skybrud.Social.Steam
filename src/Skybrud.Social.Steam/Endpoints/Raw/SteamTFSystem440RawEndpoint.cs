using Skybrud.Social.Http;
using Skybrud.Social.Steam.OAuth;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the tf system 440 endpoint.
    /// </summary>
    public class SteamTFSystem440RawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal SteamTFSystem440RawEndpoint(SteamOAuthClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SocialHttpResponse GetWorldStatus()
        {
            return Client.DoHttpGetRequest("/ITFSystem_440/GetWorldStatus/v1/");
        }

        #endregion

    }
}
