using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.OAuth;
using Skybrud.Social.Steam.Options.RemoteStorage;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the Steam remote storage endpoint.
    /// </summary>
    public class SteamRemoteStorageRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal SteamRemoteStorageRawEndpoint(SteamOAuthClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collectionCount"></param>
        /// <param name="publishedFields"></param>
        /// <returns></returns>
        public SocialHttpResponse GetCollectionDetails(uint collectionCount, ulong publishedFields)
        {
            return GetCollectionDetails(new SteamGetCollectionDetailsOptions
            {
                CollectionCount = collectionCount,
                PublishedFields = publishedFields
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetCollectionDetails(SteamGetCollectionDetailsOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpPostRequest("/ISteamRemoteStorage/GetCollectionDetails/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemCount"></param>
        /// <param name="publishedFields"></param>
        /// <returns></returns>
        public SocialHttpResponse GetPublishedFileDetails(uint itemCount, ulong publishedFields)
        {
            return GetPublishedFileDetails(new SteamGetPublishedFileDetailsOptions {ItemCount = itemCount, PublishedFields = publishedFields});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetPublishedFileDetails(SteamGetPublishedFileDetailsOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpPostRequest("/ISteamRemoteStorage/GetPublishedFileDetails/v1/", options);
        }

        #endregion

    }
}
