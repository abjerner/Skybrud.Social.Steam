using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Responses.GCVersion;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the gc version 440 endpoint.
    /// </summary>
    public class SteamGCVersion440Endpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamGCVersion440RawEndpoint Raw => Service.Client.GCVersion440;

        #endregion

        #region Constructors

        internal SteamGCVersion440Endpoint(SteamService service)
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
