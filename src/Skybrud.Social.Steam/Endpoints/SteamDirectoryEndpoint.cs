using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.Directory;
using Skybrud.Social.Steam.Responses.Directory;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the Steam Directory endpoint.
    /// </summary>
    public class SteamDirectoryEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamDirectoryRawEndpoint Raw => Service.Client.Directory;

        #endregion

        #region Constructors

        internal SteamDirectoryEndpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cellId"></param>
        /// <param name="maxCount"></param>
        /// <returns></returns>
        public SteamGetCMListResponse GetCMList(uint cellId, uint? maxCount = null)
        {
            return SteamGetCMListResponse.ParseResponse(Raw.GetCMList(cellId, maxCount));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetCMListResponse GetCMList(SteamGetCMListOptions options)
        {
            return SteamGetCMListResponse.ParseResponse(Raw.GetCMList(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cellId"></param>
        /// <param name="maxCount"></param>
        /// <returns></returns>
        public SteamGetCSListResponse GetCSList(uint cellId, uint? maxCount = null)
        {
            return SteamGetCSListResponse.ParseResponse(Raw.GetCSList(cellId, maxCount));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetCSListResponse GetCSList(SteamGetCSListOptions options)
        {
            return SteamGetCSListResponse.ParseResponse(Raw.GetCSList(options));
        }

        #endregion

    }
}
