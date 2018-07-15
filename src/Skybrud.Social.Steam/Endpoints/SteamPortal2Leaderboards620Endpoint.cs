using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.Portal2Leaderboards;
using Skybrud.Social.Steam.Responses.Portal2Leaderboards;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the portal 2 leaderboards 620 endpoint.
    /// </summary>
    public class SteamPortal2Leaderboards620Endpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamPortal2Leaderboards620RawEndpoint Raw => Service.Client.Portal2Leaderboards620;

        #endregion

        #region Constructors

        internal SteamPortal2Leaderboards620Endpoint(SteamService service)
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
