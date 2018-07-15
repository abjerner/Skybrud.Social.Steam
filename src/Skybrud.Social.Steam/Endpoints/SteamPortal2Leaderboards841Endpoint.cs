using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.Portal2Leaderboards;
using Skybrud.Social.Steam.Responses.Portal2Leaderboards;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the portal 2 leaderboards 841 endpoint.
    /// </summary>
    public class SteamPortal2Leaderboards841Endpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamPortal2Leaderboards841RawEndpoint Raw => Service.Client.Portal2Leaderboards841;

        #endregion

        #region Constructors

        internal SteamPortal2Leaderboards841Endpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="leaderboardName"></param>
        /// <returns></returns>
        public SteamGetBucketizedDataResponse GetBucketizedData(string leaderboardName)
        {
            return SteamGetBucketizedDataResponse.ParseResponse(Raw.GetBucketizedData(leaderboardName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetBucketizedDataResponse GetBucketizedData(SteamGetBucketizedDataOptions options)
        {
            return SteamGetBucketizedDataResponse.ParseResponse(Raw.GetBucketizedData(options));
        }

        #endregion

    }
}
