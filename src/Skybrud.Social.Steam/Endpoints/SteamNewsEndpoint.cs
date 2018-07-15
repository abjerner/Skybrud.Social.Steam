using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.News;
using Skybrud.Social.Steam.Responses.News;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the Steam news endpoint.
    /// </summary>
    public class SteamNewsEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamNewsRawEndpoint Raw => Service.Client.News;

        #endregion

        #region Constructors

        internal SteamNewsEndpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="maxLength"></param>
        /// <param name="endDate"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public SteamGetNewsForAppv1Response GetNewsForAppv1(uint appId, uint? maxLength = null, uint? endDate = null, uint? count = null)
        {
            return SteamGetNewsForAppv1Response.ParseResponse(Raw.GetNewsForAppv1(appId, maxLength, endDate, count));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetNewsForAppv1Response GetNewsForAppv1(SteamGetNewsForAppv1Options options)
        {
            return SteamGetNewsForAppv1Response.ParseResponse(Raw.GetNewsForAppv1(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="maxLength"></param>
        /// <param name="endDate"></param>
        /// <param name="count"></param>
        /// <param name="feeds"></param>
        /// <returns></returns>
        public SteamGetNewsForAppv2Response GetNewsForAppv2(uint appId, uint? maxLength = null, uint? endDate = null, uint? count = null, string feeds = null)
        {
            return SteamGetNewsForAppv2Response.ParseResponse(Raw.GetNewsForAppv2(appId, maxLength, endDate, count, feeds));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetNewsForAppv2Response GetNewsForAppv2(SteamGetNewsForAppv2Options options)
        {
            return SteamGetNewsForAppv2Response.ParseResponse(Raw.GetNewsForAppv2(options));
        }

        #endregion

    }
}
