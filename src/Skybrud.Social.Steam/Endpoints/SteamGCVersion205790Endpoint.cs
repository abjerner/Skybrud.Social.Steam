using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Responses.GCVersion;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the gc version 205790 endpoint.
    /// </summary>
    public class SteamGCVersion205790Endpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamGCVersion205790RawEndpoint Raw => Service.Client.GCVersion205790;

        #endregion

        #region Constructors

        internal SteamGCVersion205790Endpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SteamGetClientVersionResponse GetClientVersion()
        {
            return SteamGetClientVersionResponse.ParseResponse(Raw.GetClientVersion());
        }

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
