using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.UserStats;

namespace Skybrud.Social.Steam.Responses.UserStats
{
    /// <summary>
    /// Class representing the response of a call to get the achievements for a player.
    /// </summary>
    public class SteamGetPlayerAchievementsResponse : SteamResponse<SteamPlayerAchievements>
    {

        #region Constructors

        private SteamGetPlayerAchievementsResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamPlayerAchievements.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetPlayerAchievementsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetPlayerAchievementsResponse"/>.</returns>
        public static SteamGetPlayerAchievementsResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetPlayerAchievementsResponse(response);
        }

        #endregion

    }
}
