﻿using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.UserStats;

namespace Skybrud.Social.Steam.Responses.UserStats
{
    /// <summary>
    /// Class representing the response of a call to get the global achievement percentages for an app.
    /// </summary>
    public class SteamGetGlobalAchievementPercentagesForAppv1Response : SteamResponse<SteamAppGlobalAchievementPercentages>
    {

        #region Constructors

        private SteamGetGlobalAchievementPercentagesForAppv1Response(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamAppGlobalAchievementPercentages.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetGlobalAchievementPercentagesForAppv1Response"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetGlobalAchievementPercentagesForAppv1Response"/>.</returns>
        public static SteamGetGlobalAchievementPercentagesForAppv1Response ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetGlobalAchievementPercentagesForAppv1Response(response);
        }

        #endregion

    }
}
