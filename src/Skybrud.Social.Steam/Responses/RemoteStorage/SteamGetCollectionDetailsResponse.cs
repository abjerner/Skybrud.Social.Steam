﻿using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.RemoteStorage;

namespace Skybrud.Social.Steam.Responses.RemoteStorage
{
    /// <summary>
    /// Class representing the response of a call to get the details of a collection.
    /// </summary>
    public class SteamGetCollectionDetailsResponse : SteamResponse<SteamCollectionDetails>
    {

        #region Constructors

        private SteamGetCollectionDetailsResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamCollectionDetails.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetCollectionDetailsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetCollectionDetailsResponse"/>.</returns>
        public static SteamGetCollectionDetailsResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetCollectionDetailsResponse(response);
        }

        #endregion

    }
}
