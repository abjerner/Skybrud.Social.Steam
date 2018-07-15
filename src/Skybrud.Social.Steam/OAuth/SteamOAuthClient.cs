using System.Linq;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Endpoints.Raw;

namespace Skybrud.Social.Steam.OAuth
{
    /// <inheritdoc />
    /// <summary>
    /// Class for handling the raw communication with the Steam api as well as any OAuth communication.
    /// </summary>
    public class SteamOAuthClient : SocialHttpClient
    {

        #region Properties

        #region OAuth

        /// <summary>
        /// Gets or sets the client id of the app.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        public string AccessToken { get; set; }

        #endregion

        #region Endpoints

        /// <summary>
        /// Gets a reference to the account recovery endpoint.
        /// </summary>
        public SteamAccountRecoveryServiceRawEndpoint AccountRecovery { get; }

        /// <summary>
        /// Gets a reference to the apps endpoint.
        /// </summary>
        public SteamAppsRawEndpoint Apps { get; }

        /// <summary>
        /// Gets a reference to the directory endpoint.
        /// </summary>
        public SteamDirectoryRawEndpoint Directory { get; }

        /// <summary>
        /// Gets a reference to the envoy endpoint.
        /// </summary>
        public SteamEnvoyRawEndpoint Envoy { get; }

        /// <summary>
        /// Gets a reference to the game notification endpoint.
        /// </summary>
        public SteamGameNotificationServiceRawEndpoint GameNotification { get; }

        /// <summary>
        /// Gets a reference to the gc version 205790 endpoint.
        /// </summary>
        public SteamGCVersion205790RawEndpoint GCVersion205790 { get; }

        /// <summary>
        /// Gets a reference to the gc version 440 endpoint.
        /// </summary>
        public SteamGCVersion440RawEndpoint GCVersion440 { get; }

        /// <summary>
        /// Gets a reference to the gc version 570 endpoint.
        /// </summary>
        public SteamGCVersion570RawEndpoint GCVersion570 { get; }

        /// <summary>
        /// Gets a reference to the gc version 730 endpoint.
        /// </summary>
        public SteamGCVersion730RawEndpoint GCVersion730 { get; }

        /// <summary>
        /// Gets a reference to the news endpoint.
        /// </summary>
        public SteamNewsRawEndpoint News { get; }

        /// <summary>
        /// Gets a reference to the player endpoint.
        /// </summary>
        public SteamPlayerServiceRawEndpoint Player { get; }

        /// <summary>
        /// Gets a reference to the portal 2 leaderboards 620 endpoint.
        /// </summary>
        public SteamPortal2Leaderboards620RawEndpoint Portal2Leaderboards620 { get; }

        /// <summary>
        /// Gets a reference to the portal 2 leaderboards 841 endpoint.
        /// </summary>
        public SteamPortal2Leaderboards841RawEndpoint Portal2Leaderboards841 { get; }

        /// <summary>
        /// Gets a reference to the remote storage endpoint.
        /// </summary>
        public SteamRemoteStorageRawEndpoint RemoteStorage { get; }

        /// <summary>
        /// Gets a reference to the tf 440 endpoint.
        /// </summary>
        public SteamTFSystem440RawEndpoint TF440 { get; }

        /// <summary>
        /// Gets a reference to the user auth endpoint.
        /// </summary>
        public SteamUserAuthRawEndpoint UserAuth { get; }

        /// <summary>
        /// Gets a reference to the user OAuth endpoint.
        /// </summary>
        public SteamUserOAuthRawEndpoint UserOAuth { get; }

        /// <summary>
        /// Gets a reference to the user endpoint.
        /// </summary>
        public SteamUserRawEndpoint User { get; }

        /// <summary>
        /// Gets a reference to the user stats endpoint.
        /// </summary>
        public SteamUserStatsRawEndpoint UserStats { get; }

        /// <summary>
        /// Gets a reference to the web api util endpoint.
        /// </summary>
        public SteamWebAPIUtilRawEndpoint WebAPIUtil { get; }

        /// <summary>
        /// Gets a reference to the web user presence OAuth endpoint.
        /// </summary>
        public SteamWebUserPresenceOAuthRawEndpoint WebUserPresenceOAuth { get; }

        #endregion

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an OAuth client with empty information.
        /// </summary>
        public SteamOAuthClient()
        {
            AccountRecovery = new SteamAccountRecoveryServiceRawEndpoint(this);
            Apps = new SteamAppsRawEndpoint(this);
            Directory = new SteamDirectoryRawEndpoint(this);
            Envoy = new SteamEnvoyRawEndpoint(this);
            GameNotification = new SteamGameNotificationServiceRawEndpoint(this);
            GCVersion205790 = new SteamGCVersion205790RawEndpoint(this);
            GCVersion440 = new SteamGCVersion440RawEndpoint(this);
            GCVersion570 = new SteamGCVersion570RawEndpoint(this);
            GCVersion730 = new SteamGCVersion730RawEndpoint(this);
            News = new SteamNewsRawEndpoint(this);
            Player = new SteamPlayerServiceRawEndpoint(this);
            Portal2Leaderboards620 = new SteamPortal2Leaderboards620RawEndpoint(this);
            Portal2Leaderboards841 = new SteamPortal2Leaderboards841RawEndpoint(this);
            RemoteStorage = new SteamRemoteStorageRawEndpoint(this);
            TF440 = new SteamTFSystem440RawEndpoint(this);
            UserAuth = new SteamUserAuthRawEndpoint(this);
            UserOAuth = new SteamUserOAuthRawEndpoint(this);
            User = new SteamUserRawEndpoint(this);
            UserStats = new SteamUserStatsRawEndpoint(this);
            WebAPIUtil = new SteamWebAPIUtilRawEndpoint(this);
            WebUserPresenceOAuth = new SteamWebUserPresenceOAuthRawEndpoint(this);
        }

        #endregion

        #region Methods

        // Need methods to set ClientId and AccessToken

        // Need methods for authorization process

        protected override void PrepareHttpRequest(SocialHttpRequest request)
        {
            // Append the http scheme if not already specified
            if (request.Url.StartsWith("/"))
            {
                request.Url = "http://api.steampowered.com" + request.Url;
            }
            
            // Append the client id to the query string if present in the client and not already
            // specified in the query string
            if (!request.QueryString.Keys.Contains("key"))
            {
                request.QueryString.Add("key", ClientId);
            }

            // Don't think this needs to be done at all
            // Append the access token to the headers if present in the client and not already
            // specified in the headers
            //if (!request.Headers.Keys.Contains("AccessToken"))
            //{
            //    request.Headers.Add("AccessToken", AccessToken);
            //}
        }

        #endregion
        
    }
}
