using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Responses.TF;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the tf system 440 endpoint.
    /// </summary>
    public class SteamTFSystem440Endpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamTFSystem440RawEndpoint Raw => Service.Client.TF440;

        #endregion

        #region Constructors

        internal SteamTFSystem440Endpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SteamGetWorldStatusResponse GetWorldStatus()
        {
            return SteamGetWorldStatusResponse.ParseResponse(Raw.GetWorldStatus());
        }

        #endregion

    }
}
