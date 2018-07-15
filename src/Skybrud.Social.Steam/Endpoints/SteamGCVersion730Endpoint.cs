using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Responses.GCVersion;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the gc version 730 endpoint.
    /// </summary>
    public class SteamGCVersion730Endpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamGCVersion730RawEndpoint Raw => Service.Client.GCVersion730;

        #endregion

        #region Constructors

        internal SteamGCVersion730Endpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SteamGetServerVersionResponse GetServerVersion()
        {
            return SteamGetServerVersionResponse.ParseResponse(Raw.GetServerVersion());
        }

        #endregion

    }
}
