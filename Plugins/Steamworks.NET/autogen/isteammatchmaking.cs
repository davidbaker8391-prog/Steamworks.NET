// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2015 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamMatchmaking {
		/// <summary>
		/// <para> game server favorites storage</para>
		/// <para> saves basic details about a multiplayer game server locally</para>
		/// <para> returns the number of favorites servers the user has stored</para>
		/// </summary>
		public static int GetFavoriteGameCount() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetFavoriteGameCount();
		}

		/// <summary>
		/// <para> returns the details of the game server</para>
		/// <para> iGame is of range [0,GetFavoriteGameCount())</para>
		/// <para> *pnIP, *pnConnPort are filled in the with IP:port of the game server</para>
		/// <para> *punFlags specify whether the game server was stored as an explicit favorite or in the history of connections</para>
		/// <para> *pRTime32LastPlayedOnServer is filled in the with the Unix time the favorite was added</para>
		/// </summary>
		public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetFavoriteGame(iGame, out pnAppID, out pnIP, out pnConnPort, out pnQueryPort, out punFlags, out pRTime32LastPlayedOnServer);
		}

		/// <summary>
		/// <para> adds the game server to the local list; updates the time played of the server if it already exists in the list</para>
		/// </summary>
		public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_AddFavoriteGame(nAppID, nIP, nConnPort, nQueryPort, unFlags, rTime32LastPlayedOnServer);
		}

		/// <summary>
		/// <para> removes the game server from the local storage; returns true if one was removed</para>
		/// </summary>
		public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_RemoveFavoriteGame(nAppID, nIP, nConnPort, nQueryPort, unFlags);
		}

		/// <summary>
		/// <para>/////</para>
		/// <para> Game lobby functions</para>
		/// <para> Get a list of relevant lobbies</para>
		/// <para> this is an asynchronous request</para>
		/// <para> results will be returned by LobbyMatchList_t callback &amp; call result, with the number of lobbies found</para>
		/// <para> this will never return lobbies that are full</para>
		/// <para> to add more filter, the filter calls below need to be call before each and every RequestLobbyList() call</para>
		/// <para> use the CCallResult&lt;&gt; object in steam_api.h to match the SteamAPICall_t call result to a function in an object, e.g.</para>
		/// <para>		class CMyLobbyListManager</para>
		/// <para>		{</para>
		/// <para>			CCallResult&lt;CMyLobbyListManager, LobbyMatchList_t&gt; m_CallResultLobbyMatchList;</para>
		/// <para>			void FindLobbies()</para>
		/// <para>			{</para>
		/// <para>				// SteamMatchmaking()-&gt;AddRequestLobbyListFilter*() functions would be called here, before RequestLobbyList()</para>
		/// <para>				SteamAPICall_t hSteamAPICall = SteamMatchmaking()-&gt;RequestLobbyList();</para>
		/// <para>				m_CallResultLobbyMatchList.Set( hSteamAPICall, this, &amp;CMyLobbyListManager::OnLobbyMatchList );</para>
		/// <para>			}</para>
		/// <para>			void OnLobbyMatchList( LobbyMatchList_t *pLobbyMatchList, bool bIOFailure )</para>
		/// <para>			{</para>
		/// <para>				// lobby list has be retrieved from Steam back-end, use results</para>
		/// <para>			}</para>
		/// <para>		}</para>
		/// </summary>
		public static SteamAPICall_t RequestLobbyList() {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamMatchmaking_RequestLobbyList();
		}

		/// <summary>
		/// <para> filters for lobbies</para>
		/// <para> this needs to be called before RequestLobbyList() to take effect</para>
		/// <para> these are cleared on each call to RequestLobbyList()</para>
		/// </summary>
		public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListStringFilter(pchKeyToMatch, pchValueToMatch, eComparisonType);
		}

		/// <summary>
		/// <para> numerical comparison</para>
		/// </summary>
		public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListNumericalFilter(pchKeyToMatch, nValueToMatch, eComparisonType);
		}

		/// <summary>
		/// <para> returns results closest to the specified value. Multiple near filters can be added, with early filters taking precedence</para>
		/// </summary>
		public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListNearValueFilter(pchKeyToMatch, nValueToBeCloseTo);
		}

		/// <summary>
		/// <para> returns only lobbies with the specified number of slots available</para>
		/// </summary>
		public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(nSlotsAvailable);
		}

		/// <summary>
		/// <para> sets the distance for which we should search for lobbies (based on users IP address to location map on the Steam backed)</para>
		/// </summary>
		public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListDistanceFilter(eLobbyDistanceFilter);
		}

		/// <summary>
		/// <para> sets how many results to return, the lower the count the faster it is to download the lobby results &amp; details to the client</para>
		/// </summary>
		public static void AddRequestLobbyListResultCountFilter(int cMaxResults) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListResultCountFilter(cMaxResults);
		}

		public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(steamIDLobby);
		}

		/// <summary>
		/// <para> returns the CSteamID of a lobby, as retrieved by a RequestLobbyList call</para>
		/// <para> should only be called after a LobbyMatchList_t callback is received</para>
		/// <para> iLobby is of the range [0, LobbyMatchList_t::m_nLobbiesMatching)</para>
		/// <para> the returned CSteamID::IsValid() will be false if iLobby is out of range</para>
		/// </summary>
		public static CSteamID GetLobbyByIndex(int iLobby) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamMatchmaking_GetLobbyByIndex(iLobby);
		}

		/// <summary>
		/// <para> Create a lobby on the Steam servers.</para>
		/// <para> If private, then the lobby will not be returned by any RequestLobbyList() call; the CSteamID</para>
		/// <para> of the lobby will need to be communicated via game channels or via InviteUserToLobby()</para>
		/// <para> this is an asynchronous request</para>
		/// <para> results will be returned by LobbyCreated_t callback and call result; lobby is joined &amp; ready to use at this point</para>
		/// <para> a LobbyEnter_t callback will also be received (since the local user is joining their own lobby)</para>
		/// </summary>
		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamMatchmaking_CreateLobby(eLobbyType, cMaxMembers);
		}

		/// <summary>
		/// <para> Joins an existing lobby</para>
		/// <para> this is an asynchronous request</para>
		/// <para> results will be returned by LobbyEnter_t callback &amp; call result, check m_EChatRoomEnterResponse to see if was successful</para>
		/// <para> lobby metadata is available to use immediately on this call completing</para>
		/// </summary>
		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby) {
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamMatchmaking_JoinLobby(steamIDLobby);
		}

		/// <summary>
		/// <para> Leave a lobby; this will take effect immediately on the client side</para>
		/// <para> other users in the lobby will be notified by a LobbyChatUpdate_t callback</para>
		/// </summary>
		public static void LeaveLobby(CSteamID steamIDLobby) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_LeaveLobby(steamIDLobby);
		}

		/// <summary>
		/// <para> Invite another user to the lobby</para>
		/// <para> the target user will receive a LobbyInvite_t callback</para>
		/// <para> will return true if the invite is successfully sent, whether or not the target responds</para>
		/// <para> returns false if the local user is not connected to the Steam servers</para>
		/// <para> if the other user clicks the join link, a GameLobbyJoinRequested_t will be posted if the user is in-game,</para>
		/// <para> or if the game isn't running yet the game will be launched with the parameter +connect_lobby &lt;64-bit lobby id&gt;</para>
		/// </summary>
		public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_InviteUserToLobby(steamIDLobby, steamIDInvitee);
		}

		/// <summary>
		/// <para> Lobby iteration, for viewing details of users in a lobby</para>
		/// <para> only accessible if the lobby user is a member of the specified lobby</para>
		/// <para> persona information for other lobby members (name, avatar, etc.) will be asynchronously received</para>
		/// <para> and accessible via ISteamFriends interface</para>
		/// <para> returns the number of users in the specified lobby</para>
		/// </summary>
		public static int GetNumLobbyMembers(CSteamID steamIDLobby) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetNumLobbyMembers(steamIDLobby);
		}

		/// <summary>
		/// <para> returns the CSteamID of a user in the lobby</para>
		/// <para> iMember is of range [0,GetNumLobbyMembers())</para>
		/// <para> note that the current user must be in a lobby to retrieve CSteamIDs of other users in that lobby</para>
		/// </summary>
		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamMatchmaking_GetLobbyMemberByIndex(steamIDLobby, iMember);
		}

		/// <summary>
		/// <para> Get data associated with this lobby</para>
		/// <para> takes a simple key, and returns the string associated with it</para>
		/// <para> "" will be returned if no value is set, or if steamIDLobby is invalid</para>
		/// </summary>
		public static string GetLobbyData(CSteamID steamIDLobby, string pchKey) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamMatchmaking_GetLobbyData(steamIDLobby, pchKey));
		}

		/// <summary>
		/// <para> Sets a key/value pair in the lobby metadata</para>
		/// <para> each user in the lobby will be broadcast this new value, and any new users joining will receive any existing data</para>
		/// <para> this can be used to set lobby names, map, etc.</para>
		/// <para> to reset a key, just set it to ""</para>
		/// <para> other users in the lobby will receive notification of the lobby data change via a LobbyDataUpdate_t callback</para>
		/// </summary>
		public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyData(steamIDLobby, pchKey, pchValue);
		}

		/// <summary>
		/// <para> returns the number of metadata keys set on the specified lobby</para>
		/// </summary>
		public static int GetLobbyDataCount(CSteamID steamIDLobby) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyDataCount(steamIDLobby);
		}

		/// <summary>
		/// <para> returns a lobby metadata key/values pair by index, of range [0, GetLobbyDataCount())</para>
		/// </summary>
		public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchKey2 = Marshal.AllocHGlobal(cchKeyBufferSize);
			IntPtr pchValue2 = Marshal.AllocHGlobal(cchValueBufferSize);
			bool ret = NativeMethods.ISteamMatchmaking_GetLobbyDataByIndex(steamIDLobby, iLobbyData, pchKey2, cchKeyBufferSize, pchValue2, cchValueBufferSize);
			pchKey = ret ? InteropHelp.PtrToStringUTF8(pchKey2) : null;
			pchValue = ret ? InteropHelp.PtrToStringUTF8(pchValue2) : null;
			Marshal.FreeHGlobal(pchKey2);
			Marshal.FreeHGlobal(pchValue2);
			return ret;
		}

		/// <summary>
		/// <para> removes a metadata key from the lobby</para>
		/// </summary>
		public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_DeleteLobbyData(steamIDLobby, pchKey);
		}

		/// <summary>
		/// <para> Gets per-user metadata for someone in this lobby</para>
		/// </summary>
		public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamMatchmaking_GetLobbyMemberData(steamIDLobby, steamIDUser, pchKey));
		}

		/// <summary>
		/// <para> Sets per-user metadata (for the local user implicitly)</para>
		/// </summary>
		public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_SetLobbyMemberData(steamIDLobby, pchKey, pchValue);
		}

		/// <summary>
		/// <para> Broadcasts a chat message to the all the users in the lobby</para>
		/// <para> users in the lobby (including the local user) will receive a LobbyChatMsg_t callback</para>
		/// <para> returns true if the message is successfully sent</para>
		/// <para> pvMsgBody can be binary or text data, up to 4k</para>
		/// <para> if pvMsgBody is text, cubMsgBody should be strlen( text ) + 1, to include the null terminator</para>
		/// </summary>
		public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SendLobbyChatMsg(steamIDLobby, pvMsgBody, cubMsgBody);
		}

		/// <summary>
		/// <para> Get a chat message as specified in a LobbyChatMsg_t callback</para>
		/// <para> iChatID is the LobbyChatMsg_t::m_iChatID value in the callback</para>
		/// <para> *pSteamIDUser is filled in with the CSteamID of the member</para>
		/// <para> *pvData is filled in with the message itself</para>
		/// <para> return value is the number of bytes written into the buffer</para>
		/// </summary>
		public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyChatEntry(steamIDLobby, iChatID, out pSteamIDUser, pvData, cubData, out peChatEntryType);
		}

		/// <summary>
		/// <para> Refreshes metadata for a lobby you're not necessarily in right now</para>
		/// <para> you never do this for lobbies you're a member of, only if your</para>
		/// <para> this will send down all the metadata associated with a lobby</para>
		/// <para> this is an asynchronous call</para>
		/// <para> returns false if the local user is not connected to the Steam servers</para>
		/// <para> results will be returned by a LobbyDataUpdate_t callback</para>
		/// <para> if the specified lobby doesn't exist, LobbyDataUpdate_t::m_bSuccess will be set to false</para>
		/// </summary>
		public static bool RequestLobbyData(CSteamID steamIDLobby) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_RequestLobbyData(steamIDLobby);
		}

		/// <summary>
		/// <para> sets the game server associated with the lobby</para>
		/// <para> usually at this point, the users will join the specified game server</para>
		/// <para> either the IP/Port or the steamID of the game server has to be valid, depending on how you want the clients to be able to connect</para>
		/// </summary>
		public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_SetLobbyGameServer(steamIDLobby, unGameServerIP, unGameServerPort, steamIDGameServer);
		}

		/// <summary>
		/// <para> returns the details of a game server set in a lobby - returns false if there is no game server set, or that lobby doesn't exist</para>
		/// </summary>
		public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyGameServer(steamIDLobby, out punGameServerIP, out punGameServerPort, out psteamIDGameServer);
		}

		/// <summary>
		/// <para> set the limit on the # of users who can join the lobby</para>
		/// </summary>
		public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyMemberLimit(steamIDLobby, cMaxMembers);
		}

		/// <summary>
		/// <para> returns the current limit on the # of users who can join the lobby; returns 0 if no limit is defined</para>
		/// </summary>
		public static int GetLobbyMemberLimit(CSteamID steamIDLobby) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyMemberLimit(steamIDLobby);
		}

		/// <summary>
		/// <para> updates which type of lobby it is</para>
		/// <para> only lobbies that are k_ELobbyTypePublic or k_ELobbyTypeInvisible, and are set to joinable, will be returned by RequestLobbyList() calls</para>
		/// </summary>
		public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyType(steamIDLobby, eLobbyType);
		}

		/// <summary>
		/// <para> sets whether or not a lobby is joinable - defaults to true for a new lobby</para>
		/// <para> if set to false, no user can join, even if they are a friend or have been invited</para>
		/// </summary>
		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyJoinable(steamIDLobby, bLobbyJoinable);
		}

		/// <summary>
		/// <para> returns the current lobby owner</para>
		/// <para> you must be a member of the lobby to access this</para>
		/// <para> there always one lobby owner - if the current owner leaves, another user will become the owner</para>
		/// <para> it is possible (bur rare) to join a lobby just as the owner is leaving, thus entering a lobby with self as the owner</para>
		/// </summary>
		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamMatchmaking_GetLobbyOwner(steamIDLobby);
		}

		/// <summary>
		/// <para> changes who the lobby owner is</para>
		/// <para> you must be the lobby owner for this to succeed, and steamIDNewOwner must be in the lobby</para>
		/// <para> after completion, the local user will no longer be the owner</para>
		/// </summary>
		public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyOwner(steamIDLobby, steamIDNewOwner);
		}

		/// <summary>
		/// <para> link two lobbies for the purposes of checking player compatibility</para>
		/// <para> you must be the lobby owner of both lobbies</para>
		/// </summary>
		public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLinkedLobby(steamIDLobby, steamIDLobbyDependent);
		}
#if _PS3
		/// <summary>
		/// <para> changes who the lobby owner is</para>
		/// <para> you must be the lobby owner for this to succeed, and steamIDNewOwner must be in the lobby</para>
		/// <para> after completion, the local user will no longer be the owner</para>
		/// </summary>
		public static void CheckForPSNGameBootInvite(uint iGameBootAttributes) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_CheckForPSNGameBootInvite(iGameBootAttributes);
		}
#endif
	}
	public static class SteamMatchmakingServers {
		/// <summary>
		/// <para> Request a new list of servers of a particular type.  These calls each correspond to one of the EMatchMakingType values.</para>
		/// <para> Each call allocates a new asynchronous request object.</para>
		/// <para> Request object must be released by calling ReleaseRequest( hServerListRequest )</para>
		/// </summary>
		public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) {
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestInternetServerList(iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse) {
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestLANServerList(iApp, (IntPtr)pRequestServersResponse);
		}

		public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) {
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestFriendsServerList(iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) {
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestFavoritesServerList(iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) {
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestHistoryServerList(iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) {
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestSpectatorServerList(iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		/// <summary>
		/// <para> Releases the asynchronous request object and cancels any pending query on it if there's a pending query in progress.</para>
		/// <para> RefreshComplete callback is not posted when request is released.</para>
		/// </summary>
		public static void ReleaseRequest(HServerListRequest hServerListRequest) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_ReleaseRequest(hServerListRequest);
		}

		/// <summary>
		/// <para>	 the filter operation codes that go in the key part of MatchMakingKeyValuePair_t should be one of these:</para>
		/// <para>		"map"</para>
		/// <para>			- Server passes the filter if the server is playing the specified map.</para>
		/// <para>		"gamedataand"</para>
		/// <para>			- Server passes the filter if the server's game data (ISteamGameServer::SetGameData) contains all of the</para>
		/// <para>			specified strings.  The value field is a comma-delimited list of strings to match.</para>
		/// <para>		"gamedataor"</para>
		/// <para>			- Server passes the filter if the server's game data (ISteamGameServer::SetGameData) contains at least one of the</para>
		/// <para>			specified strings.  The value field is a comma-delimited list of strings to match.</para>
		/// <para>		"gamedatanor"</para>
		/// <para>			- Server passes the filter if the server's game data (ISteamGameServer::SetGameData) does not contain any</para>
		/// <para>			of the specified strings.  The value field is a comma-delimited list of strings to check.</para>
		/// <para>		"gametagsand"</para>
		/// <para>			- Server passes the filter if the server's game tags (ISteamGameServer::SetGameTags) contains all</para>
		/// <para>			of the specified strings.  The value field is a comma-delimited list of strings to check.</para>
		/// <para>		"gametagsnor"</para>
		/// <para>			- Server passes the filter if the server's game tags (ISteamGameServer::SetGameTags) does not contain any</para>
		/// <para>			of the specified strings.  The value field is a comma-delimited list of strings to check.</para>
		/// <para>		"and" (x1 &amp;&amp; x2 &amp;&amp; ... &amp;&amp; xn)</para>
		/// <para>		"or" (x1 || x2 || ... || xn)</para>
		/// <para>		"nand" !(x1 &amp;&amp; x2 &amp;&amp; ... &amp;&amp; xn)</para>
		/// <para>		"nor" !(x1 || x2 || ... || xn)</para>
		/// <para>			- Performs Boolean operation on the following filters.  The operand to this filter specifies</para>
		/// <para>			the "size" of the Boolean inputs to the operation, in Key/value pairs.  (The keyvalue</para>
		/// <para>			pairs must immediately follow, i.e. this is a prefix logical operator notation.)</para>
		/// <para>			In the simplest case where Boolean expressions are not nested, this is simply</para>
		/// <para>			the number of operands.</para>
		/// <para>			For example, to match servers on a particular map or with a particular tag, would would</para>
		/// <para>			use these filters.</para>
		/// <para>				( server.map == "cp_dustbowl" || server.gametags.contains("payload") )</para>
		/// <para>				"or", "2"</para>
		/// <para>				"map", "cp_dustbowl"</para>
		/// <para>				"gametagsand", "payload"</para>
		/// <para>			If logical inputs are nested, then the operand specifies the size of the entire</para>
		/// <para>			"length" of its operands, not the number of immediate children.</para>
		/// <para>				( server.map == "cp_dustbowl" || ( server.gametags.contains("payload") &amp;&amp; !server.gametags.contains("payloadrace") ) )</para>
		/// <para>				"or", "4"</para>
		/// <para>				"map", "cp_dustbowl"</para>
		/// <para>				"and", "2"</para>
		/// <para>				"gametagsand", "payload"</para>
		/// <para>				"gametagsnor", "payloadrace"</para>
		/// <para>			Unary NOT can be achieved using either "nand" or "nor" with a single operand.</para>
		/// <para>		"addr"</para>
		/// <para>			- Server passes the filter if the server's query address matches the specified IP or IP:port.</para>
		/// <para>		"gameaddr"</para>
		/// <para>			- Server passes the filter if the server's game address matches the specified IP or IP:port.</para>
		/// <para>		The following filter operations ignore the "value" part of MatchMakingKeyValuePair_t</para>
		/// <para>		"dedicated"</para>
		/// <para>			- Server passes the filter if it passed true to SetDedicatedServer.</para>
		/// <para>		"secure"</para>
		/// <para>			- Server passes the filter if the server is VAC-enabled.</para>
		/// <para>		"notfull"</para>
		/// <para>			- Server passes the filter if the player count is less than the reported max player count.</para>
		/// <para>		"hasplayers"</para>
		/// <para>			- Server passes the filter if the player count is greater than zero.</para>
		/// <para>		"noplayers"</para>
		/// <para>			- Server passes the filter if it doesn't have any players.</para>
		/// <para>		"linux"</para>
		/// <para>			- Server passes the filter if it's a linux server</para>
		/// <para> Get details on a given server in the list, you can get the valid range of index</para>
		/// <para> values by calling GetServerCount().  You will also receive index values in</para>
		/// <para> ISteamMatchmakingServerListResponse::ServerResponded() callbacks</para>
		/// </summary>
		public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer) {
			InteropHelp.TestIfAvailableClient();
			return (gameserveritem_t)Marshal.PtrToStructure(NativeMethods.ISteamMatchmakingServers_GetServerDetails(hRequest, iServer), typeof(gameserveritem_t));
		}

		/// <summary>
		/// <para> Cancel an request which is operation on the given list type.  You should call this to cancel</para>
		/// <para> any in-progress requests before destructing a callback object that may have been passed</para>
		/// <para> to one of the above list request calls.  Not doing so may result in a crash when a callback</para>
		/// <para> occurs on the destructed object.</para>
		/// <para> Canceling a query does not release the allocated request handle.</para>
		/// <para> The request handle must be released using ReleaseRequest( hRequest )</para>
		/// </summary>
		public static void CancelQuery(HServerListRequest hRequest) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_CancelQuery(hRequest);
		}

		/// <summary>
		/// <para> Ping every server in your list again but don't update the list of servers</para>
		/// <para> Query callback installed when the server list was requested will be used</para>
		/// <para> again to post notifications and RefreshComplete, so the callback must remain</para>
		/// <para> valid until another RefreshComplete is called on it or the request</para>
		/// <para> is released with ReleaseRequest( hRequest )</para>
		/// </summary>
		public static void RefreshQuery(HServerListRequest hRequest) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_RefreshQuery(hRequest);
		}

		/// <summary>
		/// <para> Returns true if the list is currently refreshing its server list</para>
		/// </summary>
		public static bool IsRefreshing(HServerListRequest hRequest) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmakingServers_IsRefreshing(hRequest);
		}

		/// <summary>
		/// <para> How many servers in the given list, GetServerDetails above takes 0... GetServerCount() - 1</para>
		/// </summary>
		public static int GetServerCount(HServerListRequest hRequest) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmakingServers_GetServerCount(hRequest);
		}

		/// <summary>
		/// <para> Refresh a single server inside of a query (rather than all the servers )</para>
		/// </summary>
		public static void RefreshServer(HServerListRequest hRequest, int iServer) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_RefreshServer(hRequest, iServer);
		}

		/// <summary>
		/// <para>-----------------------------------------------------------------------------</para>
		/// <para> Queries to individual servers directly via IP/Port</para>
		/// <para>-----------------------------------------------------------------------------</para>
		/// <para> Request updated ping time and other details from a single server</para>
		/// </summary>
		public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse) {
			InteropHelp.TestIfAvailableClient();
			return (HServerQuery)NativeMethods.ISteamMatchmakingServers_PingServer(unIP, usPort, (IntPtr)pRequestServersResponse);
		}

		/// <summary>
		/// <para> Request the list of players currently playing on a server</para>
		/// </summary>
		public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse) {
			InteropHelp.TestIfAvailableClient();
			return (HServerQuery)NativeMethods.ISteamMatchmakingServers_PlayerDetails(unIP, usPort, (IntPtr)pRequestServersResponse);
		}

		/// <summary>
		/// <para> Request the list of rules that the server is running (See ISteamGameServer::SetKeyValue() to set the rules server side)</para>
		/// </summary>
		public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse) {
			InteropHelp.TestIfAvailableClient();
			return (HServerQuery)NativeMethods.ISteamMatchmakingServers_ServerRules(unIP, usPort, (IntPtr)pRequestServersResponse);
		}

		/// <summary>
		/// <para> Cancel an outstanding Ping/Players/Rules query from above.  You should call this to cancel</para>
		/// <para> any in-progress requests before destructing a callback object that may have been passed</para>
		/// <para> to one of the above calls to avoid crashing when callbacks occur.</para>
		/// </summary>
		public static void CancelServerQuery(HServerQuery hServerQuery) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_CancelServerQuery(hServerQuery);
		}
	}
}