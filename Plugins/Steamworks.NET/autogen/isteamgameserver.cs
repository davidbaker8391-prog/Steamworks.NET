// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2016 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamGameServer {
		/// <summary>
		/// <para> Basic server data.  These properties, if set, must be set before before calling LogOn.  They</para>
		/// <para> may not be changed after logged in.</para>
		/// <para>/ This is called by SteamGameServer_Init, and you will usually not need to call it directly</para>
		/// </summary>
		public static bool InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, string pchVersionString) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pchVersionString2 = new InteropHelp.UTF8StringHandle(pchVersionString)) {
				return NativeMethods.ISteamGameServer_InitGameServer(unIP, usGamePort, usQueryPort, unFlags, nGameAppId, pchVersionString2);
			}
		}

		/// <summary>
		/// <para>/ Game product identifier.  This is currently used by the master server for version checking purposes.</para>
		/// <para>/ It's a required field, but will eventually will go away, and the AppID will be used for this purpose.</para>
		/// </summary>
		public static void SetProduct(string pszProduct) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pszProduct2 = new InteropHelp.UTF8StringHandle(pszProduct)) {
				NativeMethods.ISteamGameServer_SetProduct(pszProduct2);
			}
		}

		/// <summary>
		/// <para>/ Description of the game.  This is a required field and is displayed in the steam server browser....for now.</para>
		/// <para>/ This is a required field, but it will go away eventually, as the data should be determined from the AppID.</para>
		/// </summary>
		public static void SetGameDescription(string pszGameDescription) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pszGameDescription2 = new InteropHelp.UTF8StringHandle(pszGameDescription)) {
				NativeMethods.ISteamGameServer_SetGameDescription(pszGameDescription2);
			}
		}

		/// <summary>
		/// <para>/ If your game is a "mod," pass the string that identifies it.  The default is an empty string, meaning</para>
		/// <para>/ this application is the original game, not a mod.</para>
		/// <para>/</para>
		/// <para>/ @see k_cbMaxGameServerGameDir</para>
		/// </summary>
		public static void SetModDir(string pszModDir) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pszModDir2 = new InteropHelp.UTF8StringHandle(pszModDir)) {
				NativeMethods.ISteamGameServer_SetModDir(pszModDir2);
			}
		}

		/// <summary>
		/// <para>/ Is this is a dedicated server?  The default value is false.</para>
		/// </summary>
		public static void SetDedicatedServer(bool bDedicated) {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetDedicatedServer(bDedicated);
		}

		/// <summary>
		/// <para> Login</para>
		/// <para>/ Begin process to login to a persistent game server account</para>
		/// <para>/</para>
		/// <para>/ You need to register for callbacks to determine the result of this operation.</para>
		/// <para>/ @see SteamServersConnected_t</para>
		/// <para>/ @see SteamServerConnectFailure_t</para>
		/// <para>/ @see SteamServersDisconnected_t</para>
		/// </summary>
		public static void LogOn(string pszToken) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pszToken2 = new InteropHelp.UTF8StringHandle(pszToken)) {
				NativeMethods.ISteamGameServer_LogOn(pszToken2);
			}
		}

		/// <summary>
		/// <para>/ Login to a generic, anonymous account.</para>
		/// <para>/</para>
		/// <para>/ Note: in previous versions of the SDK, this was automatically called within SteamGameServer_Init,</para>
		/// <para>/ but this is no longer the case.</para>
		/// </summary>
		public static void LogOnAnonymous() {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_LogOnAnonymous();
		}

		/// <summary>
		/// <para>/ Begin process of logging game server out of steam</para>
		/// </summary>
		public static void LogOff() {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_LogOff();
		}

		/// <summary>
		/// <para> status functions</para>
		/// </summary>
		public static bool BLoggedOn() {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BLoggedOn();
		}

		public static bool BSecure() {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BSecure();
		}

		public static CSteamID GetSteamID() {
			InteropHelp.TestIfAvailableGameServer();
			return (CSteamID)NativeMethods.ISteamGameServer_GetSteamID();
		}

		/// <summary>
		/// <para>/ Returns true if the master server has requested a restart.</para>
		/// <para>/ Only returns true once per request.</para>
		/// </summary>
		public static bool WasRestartRequested() {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_WasRestartRequested();
		}

		/// <summary>
		/// <para> Server state.  These properties may be changed at any time.</para>
		/// <para>/ Max player count that will be reported to server browser and client queries</para>
		/// </summary>
		public static void SetMaxPlayerCount(int cPlayersMax) {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetMaxPlayerCount(cPlayersMax);
		}

		/// <summary>
		/// <para>/ Number of bots.  Default value is zero</para>
		/// </summary>
		public static void SetBotPlayerCount(int cBotplayers) {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetBotPlayerCount(cBotplayers);
		}

		/// <summary>
		/// <para>/ Set the name of server as it will appear in the server browser</para>
		/// <para>/</para>
		/// <para>/ @see k_cbMaxGameServerName</para>
		/// </summary>
		public static void SetServerName(string pszServerName) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pszServerName2 = new InteropHelp.UTF8StringHandle(pszServerName)) {
				NativeMethods.ISteamGameServer_SetServerName(pszServerName2);
			}
		}

		/// <summary>
		/// <para>/ Set name of map to report in the server browser</para>
		/// <para>/</para>
		/// <para>/ @see k_cbMaxGameServerName</para>
		/// </summary>
		public static void SetMapName(string pszMapName) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pszMapName2 = new InteropHelp.UTF8StringHandle(pszMapName)) {
				NativeMethods.ISteamGameServer_SetMapName(pszMapName2);
			}
		}

		/// <summary>
		/// <para>/ Let people know if your server will require a password</para>
		/// </summary>
		public static void SetPasswordProtected(bool bPasswordProtected) {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetPasswordProtected(bPasswordProtected);
		}

		/// <summary>
		/// <para>/ Spectator server.  The default value is zero, meaning the service</para>
		/// <para>/ is not used.</para>
		/// </summary>
		public static void SetSpectatorPort(ushort unSpectatorPort) {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetSpectatorPort(unSpectatorPort);
		}

		/// <summary>
		/// <para>/ Name of the spectator server.  (Only used if spectator port is nonzero.)</para>
		/// <para>/</para>
		/// <para>/ @see k_cbMaxGameServerMapName</para>
		/// </summary>
		public static void SetSpectatorServerName(string pszSpectatorServerName) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pszSpectatorServerName2 = new InteropHelp.UTF8StringHandle(pszSpectatorServerName)) {
				NativeMethods.ISteamGameServer_SetSpectatorServerName(pszSpectatorServerName2);
			}
		}

		/// <summary>
		/// <para>/ Call this to clear the whole list of key/values that are sent in rules queries.</para>
		/// </summary>
		public static void ClearAllKeyValues() {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_ClearAllKeyValues();
		}

		/// <summary>
		/// <para>/ Call this to add/update a key/value pair.</para>
		/// </summary>
		public static void SetKeyValue(string pKey, string pValue) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pKey2 = new InteropHelp.UTF8StringHandle(pKey))
			using (var pValue2 = new InteropHelp.UTF8StringHandle(pValue)) {
				NativeMethods.ISteamGameServer_SetKeyValue(pKey2, pValue2);
			}
		}

		/// <summary>
		/// <para>/ Sets a string defining the "gametags" for this server, this is optional, but if it is set</para>
		/// <para>/ it allows users to filter in the matchmaking/server-browser interfaces based on the value</para>
		/// <para>/</para>
		/// <para>/ @see k_cbMaxGameServerTags</para>
		/// </summary>
		public static void SetGameTags(string pchGameTags) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pchGameTags2 = new InteropHelp.UTF8StringHandle(pchGameTags)) {
				NativeMethods.ISteamGameServer_SetGameTags(pchGameTags2);
			}
		}

		/// <summary>
		/// <para>/ Sets a string defining the "gamedata" for this server, this is optional, but if it is set</para>
		/// <para>/ it allows users to filter in the matchmaking/server-browser interfaces based on the value</para>
		/// <para>/ don't set this unless it actually changes, its only uploaded to the master once (when</para>
		/// <para>/ acknowledged)</para>
		/// <para>/</para>
		/// <para>/ @see k_cbMaxGameServerGameData</para>
		/// </summary>
		public static void SetGameData(string pchGameData) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pchGameData2 = new InteropHelp.UTF8StringHandle(pchGameData)) {
				NativeMethods.ISteamGameServer_SetGameData(pchGameData2);
			}
		}

		/// <summary>
		/// <para>/ Region identifier.  This is an optional field, the default value is empty, meaning the "world" region</para>
		/// </summary>
		public static void SetRegion(string pszRegion) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pszRegion2 = new InteropHelp.UTF8StringHandle(pszRegion)) {
				NativeMethods.ISteamGameServer_SetRegion(pszRegion2);
			}
		}

		/// <summary>
		/// <para> Player list management / authentication</para>
		/// <para> Handles receiving a new connection from a Steam user.  This call will ask the Steam</para>
		/// <para> servers to validate the users identity, app ownership, and VAC status.  If the Steam servers</para>
		/// <para> are off-line, then it will validate the cached ticket itself which will validate app ownership</para>
		/// <para> and identity.  The AuthBlob here should be acquired on the game client using SteamUser()-&gt;InitiateGameConnection()</para>
		/// <para> and must then be sent up to the game server for authentication.</para>
		/// <para> Return Value: returns true if the users ticket passes basic checks. pSteamIDUser will contain the Steam ID of this user. pSteamIDUser must NOT be NULL</para>
		/// <para> If the call succeeds then you should expect a GSClientApprove_t or GSClientDeny_t callback which will tell you whether authentication</para>
		/// <para> for the user has succeeded or failed (the steamid in the callback will match the one returned by this call)</para>
		/// </summary>
		public static bool SendUserConnectAndAuthenticate(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_SendUserConnectAndAuthenticate(unIPClient, pvAuthBlob, cubAuthBlobSize, out pSteamIDUser);
		}

		/// <summary>
		/// <para> Creates a fake user (ie, a bot) which will be listed as playing on the server, but skips validation.</para>
		/// <para> Return Value: Returns a SteamID for the user to be tracked with, you should call HandleUserDisconnect()</para>
		/// <para> when this user leaves the server just like you would for a real user.</para>
		/// </summary>
		public static CSteamID CreateUnauthenticatedUserConnection() {
			InteropHelp.TestIfAvailableGameServer();
			return (CSteamID)NativeMethods.ISteamGameServer_CreateUnauthenticatedUserConnection();
		}

		/// <summary>
		/// <para> Should be called whenever a user leaves our game server, this lets Steam internally</para>
		/// <para> track which users are currently on which servers for the purposes of preventing a single</para>
		/// <para> account being logged into multiple servers, showing who is currently on a server, etc.</para>
		/// </summary>
		public static void SendUserDisconnect(CSteamID steamIDUser) {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SendUserDisconnect(steamIDUser);
		}

		/// <summary>
		/// <para> Update the data to be displayed in the server browser and matchmaking interfaces for a user</para>
		/// <para> currently connected to the server.  For regular users you must call this after you receive a</para>
		/// <para> GSUserValidationSuccess callback.</para>
		/// <para> Return Value: true if successful, false if failure (ie, steamIDUser wasn't for an active player)</para>
		/// </summary>
		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore) {
			InteropHelp.TestIfAvailableGameServer();
			using (var pchPlayerName2 = new InteropHelp.UTF8StringHandle(pchPlayerName)) {
				return NativeMethods.ISteamGameServer_BUpdateUserData(steamIDUser, pchPlayerName2, uScore);
			}
		}

		/// <summary>
		/// <para> New auth system APIs - do not mix with the old auth system APIs.</para>
		/// <para> ----------------------------------------------------------------</para>
		/// <para> Retrieve ticket to be sent to the entity who wishes to authenticate you ( using BeginAuthSession API ).</para>
		/// <para> pcbTicket retrieves the length of the actual ticket.</para>
		/// </summary>
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket) {
			InteropHelp.TestIfAvailableGameServer();
			return (HAuthTicket)NativeMethods.ISteamGameServer_GetAuthSessionTicket(pTicket, cbMaxTicket, out pcbTicket);
		}

		/// <summary>
		/// <para> Authenticate ticket ( from GetAuthSessionTicket ) from entity steamID to be sure it is valid and isnt reused</para>
		/// <para> Registers for callbacks if the entity goes offline or cancels the ticket ( see ValidateAuthTicketResponse_t callback and EAuthSessionResponse )</para>
		/// </summary>
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BeginAuthSession(pAuthTicket, cbAuthTicket, steamID);
		}

		/// <summary>
		/// <para> Stop tracking started by BeginAuthSession - called when no longer playing game with this entity</para>
		/// </summary>
		public static void EndAuthSession(CSteamID steamID) {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_EndAuthSession(steamID);
		}

		/// <summary>
		/// <para> Cancel auth ticket from GetAuthSessionTicket, called when no longer playing game with the entity you gave the ticket to</para>
		/// </summary>
		public static void CancelAuthTicket(HAuthTicket hAuthTicket) {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_CancelAuthTicket(hAuthTicket);
		}

		/// <summary>
		/// <para> After receiving a user's authentication data, and passing it to SendUserConnectAndAuthenticate, use this function</para>
		/// <para> to determine if the user owns downloadable content specified by the provided AppID.</para>
		/// </summary>
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_UserHasLicenseForApp(steamID, appID);
		}

		/// <summary>
		/// <para> Ask if a user in in the specified group, results returns async by GSUserGroupStatus_t</para>
		/// <para> returns false if we're not connected to the steam servers and thus cannot ask</para>
		/// </summary>
		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_RequestUserGroupStatus(steamIDUser, steamIDGroup);
		}

		/// <summary>
		/// <para> these two functions s are deprecated, and will not return results</para>
		/// <para> they will be removed in a future version of the SDK</para>
		/// </summary>
		public static void GetGameplayStats() {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_GetGameplayStats();
		}

		public static SteamAPICall_t GetServerReputation() {
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_GetServerReputation();
		}

		/// <summary>
		/// <para> Returns the public IP of the server according to Steam, useful when the server is</para>
		/// <para> behind NAT and you want to advertise its IP in a lobby for other clients to directly</para>
		/// <para> connect to</para>
		/// </summary>
		public static uint GetPublicIP() {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_GetPublicIP();
		}

		/// <summary>
		/// <para> These are in GameSocketShare mode, where instead of ISteamGameServer creating its own</para>
		/// <para> socket to talk to the master server on, it lets the game use its socket to forward messages</para>
		/// <para> back and forth. This prevents us from requiring server ops to open up yet another port</para>
		/// <para> in their firewalls.</para>
		/// <para> the IP address and port should be in host order, i.e 127.0.0.1 == 0x7f000001</para>
		/// <para> These are used when you've elected to multiplex the game server's UDP socket</para>
		/// <para> rather than having the master server updater use its own sockets.</para>
		/// <para> Source games use this to simplify the job of the server admins, so they</para>
		/// <para> don't have to open up more ports on their firewalls.</para>
		/// <para> Call this when a packet that starts with 0xFFFFFFFF comes in. That means</para>
		/// <para> it's for us.</para>
		/// </summary>
		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_HandleIncomingPacket(pData, cbData, srcIP, srcPort);
		}

		/// <summary>
		/// <para> AFTER calling HandleIncomingPacket for any packets that came in that frame, call this.</para>
		/// <para> This gets a packet that the master server updater needs to send out on UDP.</para>
		/// <para> It returns the length of the packet it wants to send, or 0 if there are no more packets to send.</para>
		/// <para> Call this each frame until it returns 0.</para>
		/// </summary>
		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_GetNextOutgoingPacket(pOut, cbMaxOut, out pNetAdr, out pPort);
		}

		/// <summary>
		/// <para> Control heartbeats / advertisement with master server</para>
		/// <para> Call this as often as you like to tell the master server updater whether or not</para>
		/// <para> you want it to be active (default: off).</para>
		/// </summary>
		public static void EnableHeartbeats(bool bActive) {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_EnableHeartbeats(bActive);
		}

		/// <summary>
		/// <para> You usually don't need to modify this.</para>
		/// <para> Pass -1 to use the default value for iHeartbeatInterval.</para>
		/// <para> Some mods change this.</para>
		/// </summary>
		public static void SetHeartbeatInterval(int iHeartbeatInterval) {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetHeartbeatInterval(iHeartbeatInterval);
		}

		/// <summary>
		/// <para> Force a heartbeat to steam at the next opportunity</para>
		/// </summary>
		public static void ForceHeartbeat() {
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_ForceHeartbeat();
		}

		/// <summary>
		/// <para> associate this game server with this clan for the purposes of computing player compat</para>
		/// </summary>
		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan) {
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_AssociateWithClan(steamIDClan);
		}

		/// <summary>
		/// <para> ask if any of the current players dont want to play with this new player - or vice versa</para>
		/// </summary>
		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer) {
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_ComputeNewPlayerCompatibility(steamIDNewPlayer);
		}
	}
}