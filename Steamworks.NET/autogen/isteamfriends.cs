// This file is automatically generated!

using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamFriends {
		public static string GetPersonaName() {
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetPersonaName());
		}

		public static ulong SetPersonaName(string pchPersonaName) {
			return NativeMethods.ISteamFriends_SetPersonaName(new InteropHelp.UTF8String(pchPersonaName));
		}

		public static EPersonaState GetPersonaState() {
			return NativeMethods.ISteamFriends_GetPersonaState();
		}

		public static int GetFriendCount(int iFriendFlags) {
			return NativeMethods.ISteamFriends_GetFriendCount(iFriendFlags);
		}

		public static ulong GetFriendByIndex(int iFriend, int iFriendFlags) {
			return NativeMethods.ISteamFriends_GetFriendByIndex(iFriend, iFriendFlags);
		}

		public static EFriendRelationship GetFriendRelationship(ulong steamIDFriend) {
			return NativeMethods.ISteamFriends_GetFriendRelationship(steamIDFriend);
		}

		public static EPersonaState GetFriendPersonaState(ulong steamIDFriend) {
			return NativeMethods.ISteamFriends_GetFriendPersonaState(steamIDFriend);
		}

		public static string GetFriendPersonaName(ulong steamIDFriend) {
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendPersonaName(steamIDFriend));
		}

		public static bool GetFriendGamePlayed(ulong steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) {
			return NativeMethods.ISteamFriends_GetFriendGamePlayed(steamIDFriend, ref pFriendGameInfo);
		}

		public static string GetFriendPersonaNameHistory(ulong steamIDFriend, int iPersonaName) {
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendPersonaNameHistory(steamIDFriend, iPersonaName));
		}

		public static string GetPlayerNickname(ulong steamIDPlayer) {
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetPlayerNickname(steamIDPlayer));
		}

		public static bool HasFriend(ulong steamIDFriend, int iFriendFlags) {
			return NativeMethods.ISteamFriends_HasFriend(steamIDFriend, iFriendFlags);
		}

		public static int GetClanCount() {
			return NativeMethods.ISteamFriends_GetClanCount();
		}

		public static ulong GetClanByIndex(int iClan) {
			return NativeMethods.ISteamFriends_GetClanByIndex(iClan);
		}

		public static string GetClanName(ulong steamIDClan) {
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetClanName(steamIDClan));
		}

		public static string GetClanTag(ulong steamIDClan) {
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetClanTag(steamIDClan));
		}

		public static bool GetClanActivityCounts(ulong steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting) {
			return NativeMethods.ISteamFriends_GetClanActivityCounts(steamIDClan, out pnOnline, out pnInGame, out pnChatting);
		}

		public static ulong DownloadClanActivityCounts(IntPtr psteamIDClans, int cClansToRequest) {
			return NativeMethods.ISteamFriends_DownloadClanActivityCounts(psteamIDClans, cClansToRequest);
		}

		public static int GetFriendCountFromSource(ulong steamIDSource) {
			return NativeMethods.ISteamFriends_GetFriendCountFromSource(steamIDSource);
		}

		public static ulong GetFriendFromSourceByIndex(ulong steamIDSource, int iFriend) {
			return NativeMethods.ISteamFriends_GetFriendFromSourceByIndex(steamIDSource, iFriend);
		}

		public static bool IsUserInSource(ulong steamIDUser, ulong steamIDSource) {
			return NativeMethods.ISteamFriends_IsUserInSource(steamIDUser, steamIDSource);
		}

		public static void SetInGameVoiceSpeaking(ulong steamIDUser, bool bSpeaking) {
			NativeMethods.ISteamFriends_SetInGameVoiceSpeaking(steamIDUser, bSpeaking);
		}

		public static void ActivateGameOverlay(string pchDialog) {
			NativeMethods.ISteamFriends_ActivateGameOverlay(new InteropHelp.UTF8String(pchDialog));
		}

		public static void ActivateGameOverlayToUser(string pchDialog, ulong steamID) {
			NativeMethods.ISteamFriends_ActivateGameOverlayToUser(new InteropHelp.UTF8String(pchDialog), steamID);
		}

		public static void ActivateGameOverlayToWebPage(string pchURL) {
			NativeMethods.ISteamFriends_ActivateGameOverlayToWebPage(new InteropHelp.UTF8String(pchURL));
		}

		public static void ActivateGameOverlayToStore(uint nAppID, EOverlayToStoreFlag eFlag) {
			NativeMethods.ISteamFriends_ActivateGameOverlayToStore(nAppID, eFlag);
		}

		public static void SetPlayedWith(ulong steamIDUserPlayedWith) {
			NativeMethods.ISteamFriends_SetPlayedWith(steamIDUserPlayedWith);
		}

		public static void ActivateGameOverlayInviteDialog(ulong steamIDLobby) {
			NativeMethods.ISteamFriends_ActivateGameOverlayInviteDialog(steamIDLobby);
		}

		public static int GetSmallFriendAvatar(ulong steamIDFriend) {
			return NativeMethods.ISteamFriends_GetSmallFriendAvatar(steamIDFriend);
		}

		public static int GetMediumFriendAvatar(ulong steamIDFriend) {
			return NativeMethods.ISteamFriends_GetMediumFriendAvatar(steamIDFriend);
		}

		public static int GetLargeFriendAvatar(ulong steamIDFriend) {
			return NativeMethods.ISteamFriends_GetLargeFriendAvatar(steamIDFriend);
		}

		public static bool RequestUserInformation(ulong steamIDUser, bool bRequireNameOnly) {
			return NativeMethods.ISteamFriends_RequestUserInformation(steamIDUser, bRequireNameOnly);
		}

		public static ulong RequestClanOfficerList(ulong steamIDClan) {
			return NativeMethods.ISteamFriends_RequestClanOfficerList(steamIDClan);
		}

		public static ulong GetClanOwner(ulong steamIDClan) {
			return NativeMethods.ISteamFriends_GetClanOwner(steamIDClan);
		}

		public static int GetClanOfficerCount(ulong steamIDClan) {
			return NativeMethods.ISteamFriends_GetClanOfficerCount(steamIDClan);
		}

		public static ulong GetClanOfficerByIndex(ulong steamIDClan, int iOfficer) {
			return NativeMethods.ISteamFriends_GetClanOfficerByIndex(steamIDClan, iOfficer);
		}

		public static uint GetUserRestrictions() {
			return NativeMethods.ISteamFriends_GetUserRestrictions();
		}

		public static bool SetRichPresence(string pchKey, string pchValue) {
			return NativeMethods.ISteamFriends_SetRichPresence(new InteropHelp.UTF8String(pchKey), new InteropHelp.UTF8String(pchValue));
		}

		public static void ClearRichPresence() {
			NativeMethods.ISteamFriends_ClearRichPresence();
		}

		public static string GetFriendRichPresence(ulong steamIDFriend, string pchKey) {
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendRichPresence(steamIDFriend, new InteropHelp.UTF8String(pchKey)));
		}

		public static int GetFriendRichPresenceKeyCount(ulong steamIDFriend) {
			return NativeMethods.ISteamFriends_GetFriendRichPresenceKeyCount(steamIDFriend);
		}

		public static string GetFriendRichPresenceKeyByIndex(ulong steamIDFriend, int iKey) {
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendRichPresenceKeyByIndex(steamIDFriend, iKey));
		}

		public static void RequestFriendRichPresence(ulong steamIDFriend) {
			NativeMethods.ISteamFriends_RequestFriendRichPresence(steamIDFriend);
		}

		public static bool InviteUserToGame(ulong steamIDFriend, string pchConnectString) {
			return NativeMethods.ISteamFriends_InviteUserToGame(steamIDFriend, new InteropHelp.UTF8String(pchConnectString));
		}

		public static int GetCoplayFriendCount() {
			return NativeMethods.ISteamFriends_GetCoplayFriendCount();
		}

		public static ulong GetCoplayFriend(int iCoplayFriend) {
			return NativeMethods.ISteamFriends_GetCoplayFriend(iCoplayFriend);
		}

		public static int GetFriendCoplayTime(ulong steamIDFriend) {
			return NativeMethods.ISteamFriends_GetFriendCoplayTime(steamIDFriend);
		}

		public static uint GetFriendCoplayGame(ulong steamIDFriend) {
			return NativeMethods.ISteamFriends_GetFriendCoplayGame(steamIDFriend);
		}

		public static ulong JoinClanChatRoom(ulong steamIDClan) {
			return NativeMethods.ISteamFriends_JoinClanChatRoom(steamIDClan);
		}

		public static bool LeaveClanChatRoom(ulong steamIDClan) {
			return NativeMethods.ISteamFriends_LeaveClanChatRoom(steamIDClan);
		}

		public static int GetClanChatMemberCount(ulong steamIDClan) {
			return NativeMethods.ISteamFriends_GetClanChatMemberCount(steamIDClan);
		}

		public static ulong GetChatMemberByIndex(ulong steamIDClan, int iUser) {
			return NativeMethods.ISteamFriends_GetChatMemberByIndex(steamIDClan, iUser);
		}

		public static bool SendClanChatMessage(ulong steamIDClanChat, string pchText) {
			return NativeMethods.ISteamFriends_SendClanChatMessage(steamIDClanChat, new InteropHelp.UTF8String(pchText));
		}

		public static int GetClanChatMessage(ulong steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, IntPtr psteamidChatter) {
			return NativeMethods.ISteamFriends_GetClanChatMessage(steamIDClanChat, iMessage, prgchText, cchTextMax, out peChatEntryType, psteamidChatter);
		}

		public static bool IsClanChatAdmin(ulong steamIDClanChat, ulong steamIDUser) {
			return NativeMethods.ISteamFriends_IsClanChatAdmin(steamIDClanChat, steamIDUser);
		}

		public static bool IsClanChatWindowOpenInSteam(ulong steamIDClanChat) {
			return NativeMethods.ISteamFriends_IsClanChatWindowOpenInSteam(steamIDClanChat);
		}

		public static bool OpenClanChatWindowInSteam(ulong steamIDClanChat) {
			return NativeMethods.ISteamFriends_OpenClanChatWindowInSteam(steamIDClanChat);
		}

		public static bool CloseClanChatWindowInSteam(ulong steamIDClanChat) {
			return NativeMethods.ISteamFriends_CloseClanChatWindowInSteam(steamIDClanChat);
		}

		public static bool SetListenForFriendsMessages(bool bInterceptEnabled) {
			return NativeMethods.ISteamFriends_SetListenForFriendsMessages(bInterceptEnabled);
		}

		public static bool ReplyToFriendMessage(ulong steamIDFriend, string pchMsgToSend) {
			return NativeMethods.ISteamFriends_ReplyToFriendMessage(steamIDFriend, new InteropHelp.UTF8String(pchMsgToSend));
		}

		public static int GetFriendMessage(ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType) {
			return NativeMethods.ISteamFriends_GetFriendMessage(steamIDFriend, iMessageID, pvData, cubData, out peChatEntryType);
		}

		public static ulong GetFollowerCount(ulong steamID) {
			return NativeMethods.ISteamFriends_GetFollowerCount(steamID);
		}

		public static ulong IsFollowing(ulong steamID) {
			return NativeMethods.ISteamFriends_IsFollowing(steamID);
		}

		public static ulong EnumerateFollowingList(uint unStartIndex) {
			return NativeMethods.ISteamFriends_EnumerateFollowingList(unStartIndex);
		}
	}
}