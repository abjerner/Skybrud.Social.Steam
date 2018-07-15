using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.AccountRecovery;
using Skybrud.Social.Steam.Responses.AccountRecovery;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the account recovery service endpoint.
    /// </summary>
    public class SteamAccountRecoveryServiceEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamAccountRecoveryServiceRawEndpoint Raw => Service.Client.AccountRecovery;

        #endregion

        #region Constructors

        internal SteamAccountRecoveryServiceEndpoint(SteamService service)
        {
            Service = service;
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
        public SteamReportAccountRecoveryDataResponse ReportAccountRecoveryData(string loginUserList, string installConfig, string shaSentryFile, string machineId)
        {
            return SteamReportAccountRecoveryDataResponse.ParseResponse(Raw.ReportAccountRecoveryData(loginUserList, installConfig, shaSentryFile, machineId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamReportAccountRecoveryDataResponse ReportAccountRecoveryData(SteamReportAccountRecoveryDataOptions options)
        {
            return SteamReportAccountRecoveryDataResponse.ParseResponse(Raw.ReportAccountRecoveryData(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestHandle"></param>
        /// <returns></returns>
        public SteamRetrieveAccountRecoveryDataResponse RetrieveAccountRecoveryData(string requestHandle)
        {
            return SteamRetrieveAccountRecoveryDataResponse.ParseResponse(Raw.RetrieveAccountRecoveryData(requestHandle));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamRetrieveAccountRecoveryDataResponse RetrieveAccountRecoveryData(SteamRetrieveAccountRecoveryDataOptions options)
        {
            return SteamRetrieveAccountRecoveryDataResponse.ParseResponse(Raw.RetrieveAccountRecoveryData(options));
        }

        #endregion

    }
}
