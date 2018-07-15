using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Responses.WebAPIUtil;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the web api util endpoint.
    /// </summary>
    public class SteamWebAPIUtilEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamWebAPIUtilRawEndpoint Raw => Service.Client.WebAPIUtil;

        #endregion

        #region Constructors

        internal SteamWebAPIUtilEndpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SteamGetServerInfoResponse GetServerInfo()
        {
            return SteamGetServerInfoResponse.ParseResponse(Raw.GetServerInfo());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetSupportedAPIListResponse GetSupportedAPIList()
        {
            return SteamGetSupportedAPIListResponse.ParseResponse(Raw.GetSupportedAPIList());
        }

        #endregion

    }
}
