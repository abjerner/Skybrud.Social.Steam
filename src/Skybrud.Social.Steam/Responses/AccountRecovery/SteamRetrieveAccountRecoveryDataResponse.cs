﻿using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.AccountRecovery;

namespace Skybrud.Social.Steam.Responses.AccountRecovery
{
    /// <summary>
    /// Class representing the response of a call to retrieve account recovery data.
    /// </summary>
    public class SteamRetrieveAccountRecoveryDataResponse : SteamResponse<SteamRetrieveAccountRecoveryData>
    {

        #region Constructors

        private SteamRetrieveAccountRecoveryDataResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamRetrieveAccountRecoveryData.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamRetrieveAccountRecoveryDataResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamRetrieveAccountRecoveryDataResponse"/>.</returns>
        public static SteamRetrieveAccountRecoveryDataResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamRetrieveAccountRecoveryDataResponse(response);
        }

        #endregion

    }
}
