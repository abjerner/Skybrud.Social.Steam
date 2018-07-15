using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Player;

namespace Skybrud.Social.Steam.Responses.Player
{
    /// <summary>
    /// Class representing the response of a call to see if a user is playing a shared game.
    /// </summary>
    public class SteamIsPlayingSharedGameResponse : SteamResponse<SteamIsPlayingSharedGame>
    {

        #region Constructors

        private SteamIsPlayingSharedGameResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamIsPlayingSharedGame.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamIsPlayingSharedGameResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamIsPlayingSharedGameResponse"/>.</returns>
        public static SteamIsPlayingSharedGameResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamIsPlayingSharedGameResponse(response);
        }

        #endregion

    }
}
