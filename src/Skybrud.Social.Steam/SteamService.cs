using System;
using Skybrud.Social.Steam.Endpoints;

namespace Skybrud.Social.Steam {
    
    /// <summary>
    /// Class working as an entry point to the Steam api.
    /// </summary>
    public class SteamService {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying client.
        /// </summary>
        public SteamHttpClient Client { get; private set; }

        /// <summary>
        /// Gets a reference to the account recovery endpoint.
        /// </summary>
        public SteamAccountRecoveryServiceEndpoint AccountRecovery { get; }

        /// <summary>
        /// Gets a reference to the apps endpoint.
        /// </summary>
        public SteamAppsEndpoint Apps { get; }

        /// <summary>
        /// Gets a reference to the directory endpoint.
        /// </summary>
        public SteamDirectoryEndpoint Directory { get; }

        /// <summary>
        /// Gets a reference to the envoy endpoint.
        /// </summary>
        public SteamEnvoyEndpoint Envoy { get; }

        /// <summary>
        /// Gets a reference to the game notification endpoint.
        /// </summary>
        public SteamGameNotificationServiceEndpoint GameNotification { get; }

        /// <summary>
        /// Gets a reference to the gc version 205790 endpoint.
        /// </summary>
        public SteamGCVersion205790Endpoint GCVersion205790 { get; }

        /// <summary>
        /// Gets a reference to the gc version 440 endpoint.
        /// </summary>
        public SteamGCVersion440Endpoint GCVersion440 { get; }

        /// <summary>
        /// Gets a reference to the gc version 570 endpoint.
        /// </summary>
        public SteamGCVersion570Endpoint GCVersion570 { get; }

        /// <summary>
        /// Gets a reference to the gc version 730 endpoint.
        /// </summary>
        public SteamGCVersion730Endpoint GCVersion730 { get; }

        /// <summary>
        /// Gets a reference to the news endpoint.
        /// </summary>
        public SteamNewsEndpoint News { get; }

        /// <summary>
        /// Gets a reference to the player endpoint.
        /// </summary>
        public SteamPlayerServiceEndpoint Player { get; }

        /// <summary>
        /// Gets a reference to the portal 2 leaderboards 620 endpoint.
        /// </summary>
        public SteamPortal2Leaderboards620Endpoint Portal2Leaderboards620 { get; }

        /// <summary>
        /// Gets a reference to the portal 2 leaderboards 841 endpoint.
        /// </summary>
        public SteamPortal2Leaderboards841Endpoint Portal2Leaderboards841 { get; }

        /// <summary>
        /// Gets a reference to the remote storage endpoint.
        /// </summary>
        public SteamRemoteStorageEndpoint RemoteStorage { get; }

        /// <summary>
        /// Gets a reference to the tf 440 endpoint.
        /// </summary>
        public SteamTFSystem440Endpoint TF440 { get; }

        /// <summary>
        /// Gets a reference to the user auth endpoint.
        /// </summary>
        public SteamUserAuthEndpoint UserAuth { get; }

        /// <summary>
        /// Gets a reference to the user endpoint.
        /// </summary>
        public SteamUserEndpoint User { get; }

        /// <summary>
        /// Gets a reference to the user OAuth endpoint.
        /// </summary>
        public SteamUserOAuthEndpoint UserOAuth { get; }

        /// <summary>
        /// Gets a reference to the user stats endpoint.
        /// </summary>
        public SteamUserStatsEndpoint UserStats { get; }

        /// <summary>
        /// Gets a reference to the web api util endpoint.
        /// </summary>
        public SteamWebAPIUtilEndpoint WebAPIUtil { get; }

        /// <summary>
        /// Gets a reference to the web user presence OAuth endpoint.
        /// </summary>
        public SteamWebUserPresenceOAuthEndpoint WebUserPresenceOAuth { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public SteamService() : this(null) { }

        private SteamService(SteamHttpClient client) {
            Client = client ?? new SteamHttpClient();
            AccountRecovery = new SteamAccountRecoveryServiceEndpoint(this);
            Apps = new SteamAppsEndpoint(this);
            Directory = new SteamDirectoryEndpoint(this);
            Envoy = new SteamEnvoyEndpoint(this);
            GameNotification = new SteamGameNotificationServiceEndpoint(this);
            GCVersion205790 = new SteamGCVersion205790Endpoint(this);
            GCVersion440 = new SteamGCVersion440Endpoint(this);
            GCVersion570 = new SteamGCVersion570Endpoint(this);
            GCVersion730 = new SteamGCVersion730Endpoint(this);
            News = new SteamNewsEndpoint(this);
            Player = new SteamPlayerServiceEndpoint(this);
            Portal2Leaderboards620 = new SteamPortal2Leaderboards620Endpoint(this);
            Portal2Leaderboards841 = new SteamPortal2Leaderboards841Endpoint(this);
            RemoteStorage = new SteamRemoteStorageEndpoint(this);
            TF440 = new SteamTFSystem440Endpoint(this);
            UserAuth = new SteamUserAuthEndpoint(this);
            User = new SteamUserEndpoint(this);
            UserOAuth = new SteamUserOAuthEndpoint(this);
            UserStats = new SteamUserStatsEndpoint(this);
            WebAPIUtil = new SteamWebAPIUtilEndpoint(this);
            WebUserPresenceOAuth = new SteamWebUserPresenceOAuthEndpoint(this);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initialize a new service from the specified <paramref name="apiKey"/>. Internally a new client will be initialized from the API key.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <returns>The created instance of <see cref="SteamService"/>.</returns>
        public static SteamService CreateFromApiKey(string apiKey) {
            if (String.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey));
            return new SteamService(new SteamHttpClient(apiKey));
        }

        /// <summary>
        /// Initialize a new service from the specified<paramref name="client"/>.
        /// </summary>
        /// <param name="client">The OAuth client.</param>
        /// <returns>The created instance of <see cref="SteamService"/>.</returns>
        public static SteamService CreateFromOAuthClient(SteamHttpClient client) {
            if (client == null) throw new ArgumentNullException(nameof(client));
            return new SteamService(client);
        }

        #endregion

    }

}