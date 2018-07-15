using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.RemoteStorage;
using Skybrud.Social.Steam.Responses.RemoteStorage;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the Steam remote storage endpoint.
    /// </summary>
    public class SteamRemoteStorageEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamRemoteStorageRawEndpoint Raw => Service.Client.RemoteStorage;

        #endregion

        #region Constructors

        internal SteamRemoteStorageEndpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collectionCount"></param>
        /// <param name="publishedFields"></param>
        /// <returns></returns>
        public SteamGetCollectionDetailsResponse GetCollectionDetails(uint collectionCount, ulong publishedFields)
        {
            return SteamGetCollectionDetailsResponse.ParseResponse(Raw.GetCollectionDetails(collectionCount, publishedFields));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetCollectionDetailsResponse GetCollectionDetails(SteamGetCollectionDetailsOptions options)
        {
            return SteamGetCollectionDetailsResponse.ParseResponse(Raw.GetCollectionDetails(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemCount"></param>
        /// <param name="publishedFields"></param>
        /// <returns></returns>
        public SteamGetPublishedFileDetailsResponse GetPublishedFileDetails(uint itemCount, ulong publishedFields)
        {
            return SteamGetPublishedFileDetailsResponse.ParseResponse(Raw.GetPublishedFileDetails(itemCount, publishedFields));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetPublishedFileDetailsResponse GetPublishedFileDetails(SteamGetPublishedFileDetailsOptions options)
        {
            return SteamGetPublishedFileDetailsResponse.ParseResponse(Raw.GetPublishedFileDetails(options));
        }

        #endregion

    }
}
