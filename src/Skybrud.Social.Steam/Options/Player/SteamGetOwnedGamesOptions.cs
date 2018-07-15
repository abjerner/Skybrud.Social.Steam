using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.Player
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting a list of owned games.
    /// </summary>
    public class SteamGetOwnedGamesOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the 64 bit Steam id.
        /// </summary>
        public ulong SteamId { get; set; }

        /// <summary>
        /// Gets or sets whether or not to include app info.
        /// </summary>
        public bool? IncludeAppInfo { get; set; }

        /// <summary>
        /// Gets or sets whether or not to include played free games.
        /// </summary>
        public bool? IncludePlayedFreeGames { get; set; }

        /// <summary>
        /// Gets or sets the app ids to filter.
        /// </summary>
        public uint? AppIdsFilter { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("steamid", SteamId);
            qs.Set("include_appinfo", IncludeAppInfo);
            qs.Set("include_played_free_games", IncludePlayedFreeGames);
            qs.Set("appids_filter", AppIdsFilter);
            return qs;
        }

        #endregion

    }
}
