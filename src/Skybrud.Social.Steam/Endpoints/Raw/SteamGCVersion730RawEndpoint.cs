﻿using Skybrud.Social.Http;
using Skybrud.Social.Steam.OAuth;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the gc version 730 endpoint.
    /// </summary>
    public class SteamGCVersion730RawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal SteamGCVersion730RawEndpoint(SteamOAuthClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SocialHttpResponse GetServerVersion()
        {
            return Client.DoHttpGetRequest("/IGCVersion_730/GetServerVersion/v1/");
        }

        #endregion

    }
}
