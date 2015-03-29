// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2015 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamFriends {
		/// <summary>
		/// <para> returns the local players name - guaranteed to not be NULL.</para>
		/// <para> this is the same name as on the users community profile page</para>
		/// <para> this is stored in UTF-8 format</para>
		/// <para> like all the other interface functions that return a char *, it's important that this pointer is not saved</para>
		/// <para> off; it will eventually be free'd or re-allocated</para>
		/// </summary>
		public static string GetPersonaName() {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetPersonaName());
		}

		/// <summary>
		/// <para> Sets the player name, stores it on the server and publishes the changes to all friends who are online.</para>
		/// <para> Changes take place locally immediately, and a PersonaStateChange_t is posted, presuming success.</para>
		/// <para> The final results are available through the return value SteamAPICall_t, using SetPersonaNameResponse_t.</para>
		/// <para> If the name change fails to happen on the server, then an additional global PersonaStateChange_t will be posted</para>
		/// <para> to change the name back, in addition to the SetPersonaNameResponse_t callback.</para>
		/// </summary>
		public static SteamAPICall_t SetPersonaName(string pchPersonaName) {
			InteropHelp.TestIfAvailableClient();
			using (var pchPersonaName2 = new InteropHelp.UTF8StringHandle(pchPersonaName)) {
				return (SteamAPICall_t)NativeMethods.ISteamFriends_SetPersonaName(pchPersonaName2);
			}
		}

		/// <summary>
		/// <para> gets the status of the current user</para>
		/// </summary>
		public static EPersonaState GetPersonaState() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetPersonaState();
		}

		/// <summary>
		/// <para> friend iteration</para>
		/// <para> takes a set of k_EFriendFlags, and returns the number of users the client knows about who meet that criteria</para>
		/// <para> then GetFriendByIndex() can then be used to return the id's of each of those users</para>
		/// </summary>
		public static int GetFriendCount(EFriendFlags iFriendFlags) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendCount(iFriendFlags);
		}

		/// <summary>
		/// <para> returns the steamID of a user</para>
		/// <para> iFriend is a index of range [0, GetFriendCount())</para>
		/// <para> iFriendsFlags must be the same value as used in GetFriendCount()</para>
		/// <para> the returned CSteamID can then be used by all the functions below to access details about the user</para>
		/// </summary>
		public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetFriendByIndex(iFriend, iFriendFlags);
		}

		/// <summary>
		/// <para> returns a relationship to a user</para>
		/// </summary>
		public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendRelationship(steamIDFriend);
		}

		/// <summary>
		/// <para> returns the current status of the specified user</para>
		/// <para> this will only be known by the local user if steamIDFriend is in their friends list; on the same game server; in a chat room or lobby; or in a small group with the local user</para>
		/// </summary>
		public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendPersonaState(steamIDFriend);
		}

		/// <summary>
		/// <para> returns the name another user - guaranteed to not be NULL.</para>
		/// <para> same rules as GetFriendPersonaState() apply as to whether or not the user knowns the name of the other user</para>
		/// <para> note that on first joining a lobby, chat room or game server the local user will not known the name of the other users automatically; that information will arrive asyncronously</para>
		/// </summary>
		public static string GetFriendPersonaName(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendPersonaName(steamIDFriend));
		}

		/// <summary>
		/// <para> returns true if the friend is actually in a game, and fills in pFriendGameInfo with an extra details</para>
		/// </summary>
		public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendGamePlayed(steamIDFriend, out pFriendGameInfo);
		}

		/// <summary>
		/// <para> accesses old friends names - returns an empty string when their are no more items in the history</para>
		/// </summary>
		public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendPersonaNameHistory(steamIDFriend, iPersonaName));
		}

		/// <summary>
		/// <para> friends steam level</para>
		/// </summary>
		public static int GetFriendSteamLevel(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendSteamLevel(steamIDFriend);
		}

		/// <summary>
		/// <para> Returns nickname the current user has set for the specified player. Returns NULL if the no nickname has been set for that player.</para>
		/// </summary>
		public static string GetPlayerNickname(CSteamID steamIDPlayer) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetPlayerNickname(steamIDPlayer));
		}

		/// <summary>
		/// <para> friend grouping (tag) apis</para>
		/// <para> returns the number of friends groups</para>
		/// </summary>
		public static int GetFriendsGroupCount() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendsGroupCount();
		}

		/// <summary>
		/// <para> returns the friends group ID for the given index (invalid indices return k_FriendsGroupID_Invalid)</para>
		/// </summary>
		public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendsGroupIDByIndex(iFG);
		}

		/// <summary>
		/// <para> returns the name for the given friends group (NULL in the case of invalid friends group IDs)</para>
		/// </summary>
		public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendsGroupName(friendsGroupID));
		}

		/// <summary>
		/// <para> returns the number of members in a given friends group</para>
		/// </summary>
		public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendsGroupMembersCount(friendsGroupID);
		}

		/// <summary>
		/// <para> gets up to nMembersCount members of the given friends group, if fewer exist than requested those positions' SteamIDs will be invalid</para>
		/// </summary>
		public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_GetFriendsGroupMembersList(friendsGroupID, pOutSteamIDMembers, nMembersCount);
		}

		/// <summary>
		/// <para> returns true if the specified user meets any of the criteria specified in iFriendFlags</para>
		/// <para> iFriendFlags can be the union (binary or, |) of one or more k_EFriendFlags values</para>
		/// </summary>
		public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_HasFriend(steamIDFriend, iFriendFlags);
		}

		/// <summary>
		/// <para> clan (group) iteration and access functions</para>
		/// </summary>
		public static int GetClanCount() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanCount();
		}

		public static CSteamID GetClanByIndex(int iClan) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetClanByIndex(iClan);
		}

		public static string GetClanName(CSteamID steamIDClan) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetClanName(steamIDClan));
		}

		public static string GetClanTag(CSteamID steamIDClan) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetClanTag(steamIDClan));
		}

		/// <summary>
		/// <para> returns the most recent information we have about what's happening in a clan</para>
		/// </summary>
		public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanActivityCounts(steamIDClan, out pnOnline, out pnInGame, out pnChatting);
		}

		/// <summary>
		/// <para> for clans a user is a member of, they will have reasonably up-to-date information, but for others you'll have to download the info to have the latest</para>
		/// </summary>
		public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_DownloadClanActivityCounts(psteamIDClans, cClansToRequest);
		}

		/// <summary>
		/// <para> iterators for getting users in a chat room, lobby, game server or clan</para>
		/// <para> note that large clans that cannot be iterated by the local user</para>
		/// <para> note that the current user must be in a lobby to retrieve CSteamIDs of other users in that lobby</para>
		/// <para> steamIDSource can be the steamID of a group, game server, lobby or chat room</para>
		/// </summary>
		public static int GetFriendCountFromSource(CSteamID steamIDSource) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendCountFromSource(steamIDSource);
		}

		public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetFriendFromSourceByIndex(steamIDSource, iFriend);
		}

		/// <summary>
		/// <para> returns true if the local user can see that steamIDUser is a member or in steamIDSource</para>
		/// </summary>
		public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_IsUserInSource(steamIDUser, steamIDSource);
		}

		/// <summary>
		/// <para> User is in a game pressing the talk button (will suppress the microphone for all voice comms from the Steam friends UI)</para>
		/// </summary>
		public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_SetInGameVoiceSpeaking(steamIDUser, bSpeaking);
		}

		/// <summary>
		/// <para> activates the game overlay, with an optional dialog to open</para>
		/// <para> valid options are "Friends", "Community", "Players", "Settings", "OfficialGameGroup", "Stats", "Achievements"</para>
		/// </summary>
		public static void ActivateGameOverlay(string pchDialog) {
			InteropHelp.TestIfAvailableClient();
			using (var pchDialog2 = new InteropHelp.UTF8StringHandle(pchDialog)) {
				NativeMethods.ISteamFriends_ActivateGameOverlay(pchDialog2);
			}
		}

		/// <summary>
		/// <para> activates game overlay to a specific place</para>
		/// <para> valid options are</para>
		/// <para>		"steamid" - opens the overlay web browser to the specified user or groups profile</para>
		/// <para>		"chat" - opens a chat window to the specified user, or joins the group chat</para>
		/// <para>		"jointrade" - opens a window to a Steam Trading session that was started with the ISteamEconomy/StartTrade Web API</para>
		/// <para>		"stats" - opens the overlay web browser to the specified user's stats</para>
		/// <para>		"achievements" - opens the overlay web browser to the specified user's achievements</para>
		/// <para>		"friendadd" - opens the overlay in minimal mode prompting the user to add the target user as a friend</para>
		/// <para>		"friendremove" - opens the overlay in minimal mode prompting the user to remove the target friend</para>
		/// <para>		"friendrequestaccept" - opens the overlay in minimal mode prompting the user to accept an incoming friend invite</para>
		/// <para>		"friendrequestignore" - opens the overlay in minimal mode prompting the user to ignore an incoming friend invite</para>
		/// </summary>
		public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID) {
			InteropHelp.TestIfAvailableClient();
			using (var pchDialog2 = new InteropHelp.UTF8StringHandle(pchDialog)) {
				NativeMethods.ISteamFriends_ActivateGameOverlayToUser(pchDialog2, steamID);
			}
		}

		/// <summary>
		/// <para> activates game overlay web browser directly to the specified URL</para>
		/// <para> full address with protocol type is required, e.g. http://www.steamgames.com/</para>
		/// </summary>
		public static void ActivateGameOverlayToWebPage(string pchURL) {
			InteropHelp.TestIfAvailableClient();
			using (var pchURL2 = new InteropHelp.UTF8StringHandle(pchURL)) {
				NativeMethods.ISteamFriends_ActivateGameOverlayToWebPage(pchURL2);
			}
		}

		/// <summary>
		/// <para> activates game overlay to store page for app</para>
		/// </summary>
		public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_ActivateGameOverlayToStore(nAppID, eFlag);
		}

		/// <summary>
		/// <para> Mark a target user as 'played with'. This is a client-side only feature that requires that the calling user is</para>
		/// <para> in game</para>
		/// </summary>
		public static void SetPlayedWith(CSteamID steamIDUserPlayedWith) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_SetPlayedWith(steamIDUserPlayedWith);
		}

		/// <summary>
		/// <para> activates game overlay to open the invite dialog. Invitations will be sent for the provided lobby.</para>
		/// </summary>
		public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_ActivateGameOverlayInviteDialog(steamIDLobby);
		}

		/// <summary>
		/// <para> gets the small (32x32) avatar of the current user, which is a handle to be used in IClientUtils::GetImageRGBA(), or 0 if none set</para>
		/// </summary>
		public static int GetSmallFriendAvatar(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetSmallFriendAvatar(steamIDFriend);
		}

		/// <summary>
		/// <para> gets the medium (64x64) avatar of the current user, which is a handle to be used in IClientUtils::GetImageRGBA(), or 0 if none set</para>
		/// </summary>
		public static int GetMediumFriendAvatar(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetMediumFriendAvatar(steamIDFriend);
		}

		/// <summary>
		/// <para> gets the large (184x184) avatar of the current user, which is a handle to be used in IClientUtils::GetImageRGBA(), or 0 if none set</para>
		/// <para> returns -1 if this image has yet to be loaded, in this case wait for a AvatarImageLoaded_t callback and then call this again</para>
		/// </summary>
		public static int GetLargeFriendAvatar(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetLargeFriendAvatar(steamIDFriend);
		}

		/// <summary>
		/// <para> requests information about a user - persona name &amp; avatar</para>
		/// <para> if bRequireNameOnly is set, then the avatar of a user isn't downloaded</para>
		/// <para> - it's a lot slower to download avatars and churns the local cache, so if you don't need avatars, don't request them</para>
		/// <para> if returns true, it means that data is being requested, and a PersonaStateChanged_t callback will be posted when it's retrieved</para>
		/// <para> if returns false, it means that we already have all the details about that user, and functions can be called immediately</para>
		/// </summary>
		public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_RequestUserInformation(steamIDUser, bRequireNameOnly);
		}

		/// <summary>
		/// <para> requests information about a clan officer list</para>
		/// <para> when complete, data is returned in ClanOfficerListResponse_t call result</para>
		/// <para> this makes available the calls below</para>
		/// <para> you can only ask about clans that a user is a member of</para>
		/// <para> note that this won't download avatars automatically; if you get an officer,</para>
		/// <para> and no avatar image is available, call RequestUserInformation( steamID, false ) to download the avatar</para>
		/// </summary>
		public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_RequestClanOfficerList(steamIDClan);
		}

		/// <summary>
		/// <para> iteration of clan officers - can only be done when a RequestClanOfficerList() call has completed</para>
		/// <para> returns the steamID of the clan owner</para>
		/// </summary>
		public static CSteamID GetClanOwner(CSteamID steamIDClan) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetClanOwner(steamIDClan);
		}

		/// <summary>
		/// <para> returns the number of officers in a clan (including the owner)</para>
		/// </summary>
		public static int GetClanOfficerCount(CSteamID steamIDClan) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanOfficerCount(steamIDClan);
		}

		/// <summary>
		/// <para> returns the steamID of a clan officer, by index, of range [0,GetClanOfficerCount)</para>
		/// </summary>
		public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetClanOfficerByIndex(steamIDClan, iOfficer);
		}

		/// <summary>
		/// <para> if current user is chat restricted, he can't send or receive any text/voice chat messages.</para>
		/// <para> the user can't see custom avatars. But the user can be online and send/recv game invites.</para>
		/// <para> a chat restricted user can't add friends or join any groups.</para>
		/// </summary>
		public static uint GetUserRestrictions() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetUserRestrictions();
		}

		/// <summary>
		/// <para> Rich Presence data is automatically shared between friends who are in the same game</para>
		/// <para> Each user has a set of Key/Value pairs</para>
		/// <para> Up to 20 different keys can be set</para>
		/// <para> There are two magic keys:</para>
		/// <para>		"status"  - a UTF-8 string that will show up in the 'view game info' dialog in the Steam friends list</para>
		/// <para>		"connect" - a UTF-8 string that contains the command-line for how a friend can connect to a game</para>
		/// <para> GetFriendRichPresence() returns an empty string "" if no value is set</para>
		/// <para> SetRichPresence() to a NULL or an empty string deletes the key</para>
		/// <para> You can iterate the current set of keys for a friend with GetFriendRichPresenceKeyCount()</para>
		/// <para> and GetFriendRichPresenceKeyByIndex() (typically only used for debugging)</para>
		/// </summary>
		public static bool SetRichPresence(string pchKey, string pchValue) {
			InteropHelp.TestIfAvailableClient();
			using (var pchKey2 = new InteropHelp.UTF8StringHandle(pchKey))
			using (var pchValue2 = new InteropHelp.UTF8StringHandle(pchValue)) {
				return NativeMethods.ISteamFriends_SetRichPresence(pchKey2, pchValue2);
			}
		}

		public static void ClearRichPresence() {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_ClearRichPresence();
		}

		public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey) {
			InteropHelp.TestIfAvailableClient();
			using (var pchKey2 = new InteropHelp.UTF8StringHandle(pchKey)) {
				return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendRichPresence(steamIDFriend, pchKey2));
			}
		}

		public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendRichPresenceKeyCount(steamIDFriend);
		}

		public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendRichPresenceKeyByIndex(steamIDFriend, iKey));
		}

		/// <summary>
		/// <para> Requests rich presence for a specific user.</para>
		/// </summary>
		public static void RequestFriendRichPresence(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_RequestFriendRichPresence(steamIDFriend);
		}

		/// <summary>
		/// <para> rich invite support</para>
		/// <para> if the target accepts the invite, the pchConnectString gets added to the command-line for launching the game</para>
		/// <para> if the game is already running, a GameRichPresenceJoinRequested_t callback is posted containing the connect string</para>
		/// <para> invites can only be sent to friends</para>
		/// </summary>
		public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString) {
			InteropHelp.TestIfAvailableClient();
			using (var pchConnectString2 = new InteropHelp.UTF8StringHandle(pchConnectString)) {
				return NativeMethods.ISteamFriends_InviteUserToGame(steamIDFriend, pchConnectString2);
			}
		}

		/// <summary>
		/// <para> recently-played-with friends iteration</para>
		/// <para> this iterates the entire list of users recently played with, across games</para>
		/// <para> GetFriendCoplayTime() returns as a unix time</para>
		/// </summary>
		public static int GetCoplayFriendCount() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetCoplayFriendCount();
		}

		public static CSteamID GetCoplayFriend(int iCoplayFriend) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetCoplayFriend(iCoplayFriend);
		}

		public static int GetFriendCoplayTime(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendCoplayTime(steamIDFriend);
		}

		public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return (AppId_t)NativeMethods.ISteamFriends_GetFriendCoplayGame(steamIDFriend);
		}

		/// <summary>
		/// <para> chat interface for games</para>
		/// <para> this allows in-game access to group (clan) chats from in the game</para>
		/// <para> the behavior is somewhat sophisticated, because the user may or may not be already in the group chat from outside the game or in the overlay</para>
		/// <para> use ActivateGameOverlayToUser( "chat", steamIDClan ) to open the in-game overlay version of the chat</para>
		/// </summary>
		public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_JoinClanChatRoom(steamIDClan);
		}

		public static bool LeaveClanChatRoom(CSteamID steamIDClan) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_LeaveClanChatRoom(steamIDClan);
		}

		public static int GetClanChatMemberCount(CSteamID steamIDClan) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanChatMemberCount(steamIDClan);
		}

		public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetChatMemberByIndex(steamIDClan, iUser);
		}

		public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText) {
			InteropHelp.TestIfAvailableClient();
			using (var pchText2 = new InteropHelp.UTF8StringHandle(pchText)) {
				return NativeMethods.ISteamFriends_SendClanChatMessage(steamIDClanChat, pchText2);
			}
		}

		public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter) {
			InteropHelp.TestIfAvailableClient();
			IntPtr prgchText2 = Marshal.AllocHGlobal(cchTextMax);
			int ret = NativeMethods.ISteamFriends_GetClanChatMessage(steamIDClanChat, iMessage, prgchText2, cchTextMax, out peChatEntryType, out psteamidChatter);
			prgchText = ret != 0 ? InteropHelp.PtrToStringUTF8(prgchText2) : null;
			Marshal.FreeHGlobal(prgchText2);
			return ret;
		}

		public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_IsClanChatAdmin(steamIDClanChat, steamIDUser);
		}

		/// <summary>
		/// <para> interact with the Steam (game overlay / desktop)</para>
		/// </summary>
		public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_IsClanChatWindowOpenInSteam(steamIDClanChat);
		}

		public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_OpenClanChatWindowInSteam(steamIDClanChat);
		}

		public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_CloseClanChatWindowInSteam(steamIDClanChat);
		}

		/// <summary>
		/// <para> peer-to-peer chat interception</para>
		/// <para> this is so you can show P2P chats inline in the game</para>
		/// </summary>
		public static bool SetListenForFriendsMessages(bool bInterceptEnabled) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_SetListenForFriendsMessages(bInterceptEnabled);
		}

		public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend) {
			InteropHelp.TestIfAvailableClient();
			using (var pchMsgToSend2 = new InteropHelp.UTF8StringHandle(pchMsgToSend)) {
				return NativeMethods.ISteamFriends_ReplyToFriendMessage(steamIDFriend, pchMsgToSend2);
			}
		}

		public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pvData2 = Marshal.AllocHGlobal(cubData);
			int ret = NativeMethods.ISteamFriends_GetFriendMessage(steamIDFriend, iMessageID, pvData2, cubData, out peChatEntryType);
			pvData = ret != 0 ? InteropHelp.PtrToStringUTF8(pvData2) : null;
			Marshal.FreeHGlobal(pvData2);
			return ret;
		}

		/// <summary>
		/// <para> following apis</para>
		/// </summary>
		public static SteamAPICall_t GetFollowerCount(CSteamID steamID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_GetFollowerCount(steamID);
		}

		public static SteamAPICall_t IsFollowing(CSteamID steamID) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_IsFollowing(steamID);
		}

		public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_EnumerateFollowingList(unStartIndex);
		}
	}
}