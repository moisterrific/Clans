﻿namespace Clans
{
    /// <summary>
    ///     Holds clans permissions.
    /// </summary>
    public static class ClansPermissions
    {
        /// <summary>
        ///     The permission required for banning players.
        /// </summary>
        /// <remarks>This permission applies to clan ranks only.</remarks>
        public static readonly string BanPlayers = "clans.ranks.ban";

        /// <summary>
        ///     The permission required for creating clans.
        /// </summary>
        public static readonly string CreatePermission = "clans.create";

        /// <summary>
        ///     The permission required to mark ranks immune to kicks.
        /// </summary>
        /// <remarks>This permission applies to clan ranks only.</remarks>
        public static readonly string ImmuneToKick = "clans.ranks.immune";

        /// <summary>
        ///     The permission required for inviting players.
        /// </summary>
        /// <remarks>This permission applies to clan ranks only.</remarks>
        public static readonly string InvitePlayers = "clans.ranks.invite";

        /// <summary>
        ///     The permission required for kicking members.
        /// </summary>
        /// <remarks>This permission applies to clan ranks only.</remarks>
        public static readonly string KickMembers = "clans.ranks.kick";

        /// <summary>
        ///     The root /clan and /c permission.
        /// </summary>
        public static readonly string RootPermission = "clans.use";

        /// <summary>
        ///     The permission required for sending clan messages.
        /// </summary>
        /// <remarks>This permission applies to clan ranks only.</remarks>
        public static readonly string SendClanMessages = "clans.ranks.chat";

        /// <summary>
        ///     The permission required for changing clan colors.
        /// </summary>
        /// <remarks>This permission applies to clan ranks only.</remarks>
        public static readonly string SetClanChatColor = "clans.ranks.setcolor";

        /// <summary>
        ///     The permissions required for chaning the clan's message of the day.
        /// </summary>
        /// <remarks>This permission applies to clan ranks only.</remarks>
        public static readonly string SetClanMotd = "clans.ranks.setmotd";

        /// <summary>
        ///     The permission required for changing clan prefixes.
        /// </summary>
        /// <remarks>This permission aplies to clan ranks only.</remarks>
        public static readonly string SetClanPrefix = "clans.ranks.setprefix";

        /// <summary>
        ///     The permission required for setting a member's rank.
        /// </summary>
        /// <remarks>This permission applies to clan ranks only.</remarks>
        public static readonly string SetMemberRank = "clans.ranks.setrank";

        /// <summary>
        ///     The permission required for toggling a clan's friendly fire status.
        /// </summary>
        /// <remarks>This permission applies to clan ranks only.</remarks>
        public static readonly string ToggleFriendlyFire = "clans.ranks.togglefriendlyfire";

        /// <summary>
        ///     The permission required for toggling the clan's 'Private' flag.
        /// </summary>
        /// <remarks>This permission applies to clan ranks only.</remarks>
        public static readonly string TogglePrivateStatus = "clans.ranks.toggleprivate";
    }
}