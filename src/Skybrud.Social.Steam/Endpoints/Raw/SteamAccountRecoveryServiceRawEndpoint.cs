using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.OAuth;
using Skybrud.Social.Steam.Options.AccountRecovery;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the account recovery service endpoint.
    /// </summary>
    public class SteamAccountRecoveryServiceRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal SteamAccountRecoveryServiceRawEndpoint(SteamOAuthClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginUserList"></param>
        /// <param name="installConfig"></param>
        /// <param name="shaSentryFile"></param>
        /// <param name="machineId"></param>
        /// <returns></returns>
        public SocialHttpResponse ReportAccountRecoveryData(string loginUserList, string installConfig, string shaSentryFile, string machineId)
        {
            return ReportAccountRecoveryData(new SteamReportAccountRecoveryDataOptions
            {
                LoginUserList = loginUserList,
                InstallConfig = installConfig,
                ShaSentryFile = shaSentryFile,
                MachineId = machineId
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse ReportAccountRecoveryData(SteamReportAccountRecoveryDataOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpPostRequest("/IAccountRecoveryService/ReportAccountRecoveryData/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestHandle"></param>
        /// <returns></returns>
        public SocialHttpResponse RetrieveAccountRecoveryData(string requestHandle)
        {
            return RetrieveAccountRecoveryData(new SteamRetrieveAccountRecoveryDataOptions {RequestHandle = requestHandle});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse RetrieveAccountRecoveryData(SteamRetrieveAccountRecoveryDataOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpPostRequest("/IAccountRecoveryService/RetrieveAccountRecoveryData/v1/", options);
        }

        #endregion

    }
}
