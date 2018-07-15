using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Steam.Models.User
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing player summary as returned by the Steam api.
    /// </summary>
    public class SteamPlayerSummary : SteamObject
    {

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public ulong SteamId { get; }

        /// <summary>
        /// 
        /// </summary>
        public int CommunityVisibilityState { get; }

        /// <summary>
        /// 
        /// </summary>
        public int ProfileState { get; }

        /// <summary>
        /// 
        /// </summary>
        public string PersonaName { get; }

        /// <summary>
        /// 
        /// </summary>
        public uint LastLogOff { get; }

        /// <summary>
        /// 
        /// </summary>
        public string ProfileUrl { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Avatar { get; }

        /// <summary>
        /// 
        /// </summary>
        public string AvatarMedium { get; }

        /// <summary>
        /// 
        /// </summary>
        public string AvatarFull { get; }

        /// <summary>
        /// 
        /// </summary>
        public int PersonaState { get; }

        /// <summary>
        /// 
        /// </summary>
        public ulong PrimaryClanId { get; }

        /// <summary>
        /// 
        /// </summary>
        public uint TimeCreated { get; }

        /// <summary>
        /// 
        /// </summary>
        public int PersonaStateFlags { get; }

        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamPlayerSummary(JObject obj) : base(obj)
        {
            SteamId = obj.GetUInt64("steamid");
            CommunityVisibilityState = obj.GetInt32("communityvisibilitystate");
            ProfileState = obj.GetInt32("profilestate");
            PersonaName = obj.GetString("personaname");
            LastLogOff = obj.GetUInt32("lastlogoff");
            ProfileUrl = obj.GetString("profileurl");
            Avatar = obj.GetString("avatar");
            AvatarMedium = obj.GetString("avatarmedium");
            AvatarFull = obj.GetString("avatarfull");
            PersonaState = obj.GetInt32("personastate");
            PrimaryClanId = obj.GetUInt64("primaryclanid");
            TimeCreated = obj.GetUInt32("timecreated");
            PersonaStateFlags = obj.GetInt32("personastateflags");
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamPlayerSummary"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamPlayerSummary"/>.</returns>
        public static SteamPlayerSummary Parse(JObject obj)
        {
            return obj == null ? null : new SteamPlayerSummary(obj);
        }

        #endregion

    }
}
