using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Player;

namespace Skybrud.Social.Steam.Responses.Player
{
    /// <summary>
    /// Class representing the response of a call to record offline playtime of a user.
    /// </summary>
    public class SteamRecordOfflinePlaytimeResponse : SteamResponse<SteamRecordedOfflinePlaytime>
    {

        #region Constructors

        private SteamRecordOfflinePlaytimeResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamRecordedOfflinePlaytime.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamRecordOfflinePlaytimeResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamRecordOfflinePlaytimeResponse"/>.</returns>
        public static SteamRecordOfflinePlaytimeResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamRecordOfflinePlaytimeResponse(response);
        }

        #endregion

    }
}
