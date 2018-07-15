using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.Apps;
using Skybrud.Social.Steam.Responses.Apps;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the Steam apps endpoint.
    /// </summary>
    public class SteamAppsEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamAppsRawEndpoint Raw => Service.Client.Apps;

        #endregion

        #region Constructors

        internal SteamAppsEndpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SteamGetAppListv1Response GetAppListv1()
        {
            return SteamGetAppListv1Response.ParseResponse(Raw.GetAppListv1());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SteamGetAppListv2Response GetAppListv2()
        {
            return SteamGetAppListv2Response.ParseResponse(Raw.GetAppListv2());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        public SteamGetServersAtAddressResponse GetServerAtAddress(string addr)
        {
            return SteamGetServersAtAddressResponse.ParseResponse(Raw.GetServersAtAddress(addr));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetServersAtAddressResponse GetServerAtAddress(SteamGetServersAtAddressOptions options)
        {
            return SteamGetServersAtAddressResponse.ParseResponse(Raw.GetServersAtAddress(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public SteamUpToDateCheckResponse UpToDateCheck(uint appId, uint version)
        {
            return SteamUpToDateCheckResponse.ParseResponse(Raw.UpToDateCheck(appId, version));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamUpToDateCheckResponse UpToDateCheck(SteamUpToDateCheckOptions options)
        {
            return SteamUpToDateCheckResponse.ParseResponse(Raw.UpToDateCheck(options));
        }

        #endregion

    }
}
