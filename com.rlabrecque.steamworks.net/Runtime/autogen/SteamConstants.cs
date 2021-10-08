// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2019 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

#if !(UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX || STEAMWORKS_WIN || STEAMWORKS_LIN_OSX)
	#define DISABLESTEAMWORKS
#endif

#if !DISABLESTEAMWORKS

using System.Runtime.InteropServices;
using IntPtr = System.IntPtr;

namespace Steamworks {
	public static class Constants {
		public const string STEAMAPPLIST_INTERFACE_VERSION = "STEAMAPPLIST_INTERFACE_VERSION001";
		public const string STEAMAPPS_INTERFACE_VERSION = "STEAMAPPS_INTERFACE_VERSION008";
		public const string STEAMAPPTICKET_INTERFACE_VERSION = "STEAMAPPTICKET_INTERFACE_VERSION001";
		public const string STEAMCLIENT_INTERFACE_VERSION = "SteamClient020";
		public const string STEAMFRIENDS_INTERFACE_VERSION = "SteamFriends017";
		public const string STEAMGAMECOORDINATOR_INTERFACE_VERSION = "SteamGameCoordinator001";
		public const string STEAMGAMESERVER_INTERFACE_VERSION = "SteamGameServer014";
		public const string STEAMGAMESERVERSTATS_INTERFACE_VERSION = "SteamGameServerStats001";
		public const string STEAMHTMLSURFACE_INTERFACE_VERSION = "STEAMHTMLSURFACE_INTERFACE_VERSION_005";
		public const string STEAMHTTP_INTERFACE_VERSION = "STEAMHTTP_INTERFACE_VERSION003";
		public const string STEAMINPUT_INTERFACE_VERSION = "SteamInput005";
		public const string STEAMINVENTORY_INTERFACE_VERSION = "STEAMINVENTORY_INTERFACE_V003";
		public const string STEAMMATCHMAKING_INTERFACE_VERSION = "SteamMatchMaking009";
		public const string STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION = "SteamMatchMakingServers002";
		public const string STEAMGAMESEARCH_INTERFACE_VERSION = "SteamMatchGameSearch001";
		public const string STEAMPARTIES_INTERFACE_VERSION = "SteamParties002";
		public const string STEAMMUSIC_INTERFACE_VERSION = "STEAMMUSIC_INTERFACE_VERSION001";
		public const string STEAMMUSICREMOTE_INTERFACE_VERSION = "STEAMMUSICREMOTE_INTERFACE_VERSION001";
		public const string STEAMNETWORKING_INTERFACE_VERSION = "SteamNetworking006";
		public const string STEAMNETWORKINGMESSAGES_INTERFACE_VERSION = "SteamNetworkingMessages002";
		// Silence some warnings
		public const string STEAMNETWORKINGSOCKETS_INTERFACE_VERSION = "SteamNetworkingSockets009";
		// Silence some warnings
		public const string STEAMNETWORKINGUTILS_INTERFACE_VERSION = "SteamNetworkingUtils003";
		public const string STEAMPARENTALSETTINGS_INTERFACE_VERSION = "STEAMPARENTALSETTINGS_INTERFACE_VERSION001";
		public const string STEAMREMOTEPLAY_INTERFACE_VERSION = "STEAMREMOTEPLAY_INTERFACE_VERSION001";
		public const string STEAMREMOTESTORAGE_INTERFACE_VERSION = "STEAMREMOTESTORAGE_INTERFACE_VERSION016";
		public const string STEAMSCREENSHOTS_INTERFACE_VERSION = "STEAMSCREENSHOTS_INTERFACE_VERSION003";
		public const string STEAMUGC_INTERFACE_VERSION = "STEAMUGC_INTERFACE_VERSION015";
		public const string STEAMUSER_INTERFACE_VERSION = "SteamUser021";
		public const string STEAMUSERSTATS_INTERFACE_VERSION = "STEAMUSERSTATS_INTERFACE_VERSION012";
		public const string STEAMUTILS_INTERFACE_VERSION = "SteamUtils010";
		public const string STEAMVIDEO_INTERFACE_VERSION = "STEAMVIDEO_INTERFACE_V002";
		public const int k_cubAppProofOfPurchaseKeyMax = 240; // max supported length of a legacy cd key
		// maximum length of friend group name (not including terminating nul!)
		public const int k_cchMaxFriendsGroupName = 64;
		// maximum number of groups a single user is allowed
		public const int k_cFriendsGroupLimit = 100;
		public const int k_cEnumerateFollowersMax = 50;
		// maximum number of characters in a user's name. Two flavors; one for UTF-8 and one for UTF-16.
		// The UTF-8 version has to be very generous to accomodate characters that get large when encoded
		// in UTF-8.
		public const int k_cchPersonaNameMax = 128;
		public const int k_cwchPersonaNameMax = 32;
		// size limit on chat room or member metadata
		public const int k_cubChatMetadataMax = 8192;
		// size limits on Rich Presence data
		public const int k_cchMaxRichPresenceKeys = 30;
		public const int k_cchMaxRichPresenceKeyLength = 64;
		public const int k_cchMaxRichPresenceValueLength = 256;
		// game server flags
		public const int k_unFavoriteFlagNone = 0x00;
		public const int k_unFavoriteFlagFavorite = 0x01; // this game favorite entry is for the favorites list
		public const int k_unFavoriteFlagHistory = 0x02; // this game favorite entry is for the history list
		//-----------------------------------------------------------------------------
		// Purpose: Defines the largest allowed file size. Cloud files cannot be written
		// in a single chunk over 100MB (and cannot be over 200MB total.)
		//-----------------------------------------------------------------------------
		public const int k_unMaxCloudFileChunkSize = 100 * 1024 * 1024;
		public const int k_cchPublishedDocumentTitleMax = 128 + 1;
		public const int k_cchPublishedDocumentDescriptionMax = 8000;
		public const int k_cchPublishedDocumentChangeDescriptionMax = 8000;
		public const int k_unEnumeratePublishedFilesMaxResults = 50;
		public const int k_cchTagListMax = 1024 + 1;
		public const int k_cchFilenameMax = 260;
		public const int k_cchPublishedFileURLMax = 256;
		public const int k_nScreenshotMaxTaggedUsers = 32;
		public const int k_nScreenshotMaxTaggedPublishedFiles = 32;
		public const int k_cubUFSTagTypeMax = 255;
		public const int k_cubUFSTagValueMax = 255;
		// Required with of a thumbnail provided to AddScreenshotToLibrary.  If you do not provide a thumbnail
		// one will be generated.
		public const int k_ScreenshotThumbWidth = 200;
		public const int kNumUGCResultsPerPage = 50;
		public const int k_cchDeveloperMetadataMax = 5000;
		// size limit on stat or achievement name (UTF-8 encoded)
		public const int k_cchStatNameMax = 128;
		// maximum number of bytes for a leaderboard name (UTF-8 encoded)
		public const int k_cchLeaderboardNameMax = 128;
		// maximum number of details int32's storable for a single leaderboard entry
		public const int k_cLeaderboardDetailsMax = 64;
		//
		// Max size (in bytes of UTF-8 data, not in characters) of server fields, including null terminator.
		// WARNING: These cannot be changed easily, without breaking clients using old interfaces.
		//
		public const int k_cbMaxGameServerGameDir = 32;
		public const int k_cbMaxGameServerMapName = 32;
		public const int k_cbMaxGameServerGameDescription = 64;
		public const int k_cbMaxGameServerName = 64;
		public const int k_cbMaxGameServerTags = 128;
		public const int k_cbMaxGameServerGameData = 2048;
		//-----------------------------------------------------------------------------
		// Purpose: Base values for callback identifiers, each callback must
		//			have a unique ID.
		//-----------------------------------------------------------------------------
		public const int k_iSteamUserCallbacks = 100;
		public const int k_iSteamGameServerCallbacks = 200;
		public const int k_iSteamFriendsCallbacks = 300;
		public const int k_iSteamBillingCallbacks = 400;
		public const int k_iSteamMatchmakingCallbacks = 500;
		public const int k_iSteamContentServerCallbacks = 600;
		public const int k_iSteamUtilsCallbacks = 700;
		public const int k_iClientFriendsCallbacks = 800;
		public const int k_iClientUserCallbacks = 900;
		public const int k_iSteamAppsCallbacks = 1000;
		public const int k_iSteamUserStatsCallbacks = 1100;
		public const int k_iSteamNetworkingCallbacks = 1200;
		public const int k_iSteamNetworkingSocketsCallbacks = 1220;
		public const int k_iSteamNetworkingMessagesCallbacks = 1250;
		public const int k_iSteamNetworkingUtilsCallbacks = 1280;
		public const int k_iClientRemoteStorageCallbacks = 1300;
		public const int k_iClientDepotBuilderCallbacks = 1400;
		public const int k_iSteamGameServerItemsCallbacks = 1500;
		public const int k_iClientUtilsCallbacks = 1600;
		public const int k_iSteamGameCoordinatorCallbacks = 1700;
		public const int k_iSteamGameServerStatsCallbacks = 1800;
		public const int k_iSteam2AsyncCallbacks = 1900;
		public const int k_iSteamGameStatsCallbacks = 2000;
		public const int k_iClientHTTPCallbacks = 2100;
		public const int k_iClientScreenshotsCallbacks = 2200;
		public const int k_iSteamScreenshotsCallbacks = 2300;
		public const int k_iClientAudioCallbacks = 2400;
		public const int k_iClientUnifiedMessagesCallbacks = 2500;
		public const int k_iSteamStreamLauncherCallbacks = 2600;
		public const int k_iClientControllerCallbacks = 2700;
		public const int k_iSteamControllerCallbacks = 2800;
		public const int k_iClientParentalSettingsCallbacks = 2900;
		public const int k_iClientDeviceAuthCallbacks = 3000;
		public const int k_iClientNetworkDeviceManagerCallbacks = 3100;
		public const int k_iClientMusicCallbacks = 3200;
		public const int k_iClientRemoteClientManagerCallbacks = 3300;
		public const int k_iClientUGCCallbacks = 3400;
		public const int k_iSteamStreamClientCallbacks = 3500;
		public const int k_IClientProductBuilderCallbacks = 3600;
		public const int k_iClientShortcutsCallbacks = 3700;
		public const int k_iClientRemoteControlManagerCallbacks = 3800;
		public const int k_iSteamAppListCallbacks = 3900;
		public const int k_iSteamMusicCallbacks = 4000;
		public const int k_iSteamMusicRemoteCallbacks = 4100;
		public const int k_iClientVRCallbacks = 4200;
		public const int k_iClientGameNotificationCallbacks = 4300;
		public const int k_iSteamGameNotificationCallbacks = 4400;
		public const int k_iSteamHTMLSurfaceCallbacks = 4500;
		public const int k_iClientVideoCallbacks = 4600;
		public const int k_iClientInventoryCallbacks = 4700;
		public const int k_iClientBluetoothManagerCallbacks = 4800;
		public const int k_iClientSharedConnectionCallbacks = 4900;
		public const int k_ISteamParentalSettingsCallbacks = 5000;
		public const int k_iClientShaderCallbacks = 5100;
		public const int k_iSteamGameSearchCallbacks = 5200;
		public const int k_iSteamPartiesCallbacks = 5300;
		public const int k_iClientPartiesCallbacks = 5400;
		public const int k_iSteamSTARCallbacks = 5500;
		public const int k_iClientSTARCallbacks = 5600;
		public const int k_iSteamRemotePlayCallbacks = 5700;
		public const int k_iClientCompatCallbacks = 5800;
		public const int k_iSteamChatCallbacks = 5900;
		public const int k_iClientNetworkingUtilsCallbacks = 6000;
		public const int k_iClientSystemManagerCallbacks = 6100;
		public const int k_iClientStorageDeviceManagerCallbacks = 6200;
		/// Pass to SteamGameServer_Init to indicate that the same UDP port will be used for game traffic
		/// UDP queries for server browser pings and LAN discovery.  In this case, Steam will not open up a
		/// socket to handle server browser queries, and you must use ISteamGameServer::HandleIncomingPacket
		/// and ISteamGameServer::GetNextOutgoingPacket to handle packets related to server discovery on your socket.
		public const ushort STEAMGAMESERVER_QUERY_PORT_SHARED = 0xffff;
		public const int k_unSteamAccountIDMask = -1;
		public const int k_unSteamAccountInstanceMask = 0x000FFFFF;
		public const int k_unSteamUserDefaultInstance = 1; // fixed instance for all individual users
		public const int k_cchGameExtraInfoMax = 64;
		public const int k_nSteamEncryptedAppTicketSymmetricKeyLen = 32;
		/// Max length of diagnostic error message
		public const int k_cchMaxSteamNetworkingErrMsg = 1024;
		/// Max length, in bytes (including null terminator) of the reason string
		/// when a connection is closed.
		public const int k_cchSteamNetworkingMaxConnectionCloseReason = 128;
		/// Max length, in bytes (include null terminator) of debug description
		/// of a connection.
		public const int k_cchSteamNetworkingMaxConnectionDescription = 128;
		//
		// Network messages
		//
		/// Max size of a single message that we can SEND.
		/// Note: We might be wiling to receive larger messages,
		/// and our peer might, too.
		public const int k_cbMaxSteamNetworkingSocketsMessageSizeSend = 512 * 1024;
		//
		// Flags used to set options for message sending
		//
		// Send the message unreliably. Can be lost.  Messages *can* be larger than a
		// single MTU (UDP packet), but there is no retransmission, so if any piece
		// of the message is lost, the entire message will be dropped.
		//
		// The sending API does have some knowledge of the underlying connection, so
		// if there is no NAT-traversal accomplished or there is a recognized adjustment
		// happening on the connection, the packet will be batched until the connection
		// is open again.
		//
		// Migration note: This is not exactly the same as k_EP2PSendUnreliable!  You
		// probably want k_ESteamNetworkingSendType_UnreliableNoNagle
		public const int k_nSteamNetworkingSend_Unreliable = 0;
		// Disable Nagle's algorithm.
		// By default, Nagle's algorithm is applied to all outbound messages.  This means
		// that the message will NOT be sent immediately, in case further messages are
		// sent soon after you send this, which can be grouped together.  Any time there
		// is enough buffered data to fill a packet, the packets will be pushed out immediately,
		// but partially-full packets not be sent until the Nagle timer expires.  See
		// ISteamNetworkingSockets::FlushMessagesOnConnection, ISteamNetworkingMessages::FlushMessagesToUser
		//
		// NOTE: Don't just send every message without Nagle because you want packets to get there
		// quicker.  Make sure you understand the problem that Nagle is solving before disabling it.
		// If you are sending small messages, often many at the same time, then it is very likely that
		// it will be more efficient to leave Nagle enabled.  A typical proper use of this flag is
		// when you are sending what you know will be the last message sent for a while (e.g. the last
		// in the server simulation tick to a particular client), and you use this flag to flush all
		// messages.
		public const int k_nSteamNetworkingSend_NoNagle = 1;
		// Send a message unreliably, bypassing Nagle's algorithm for this message and any messages
		// currently pending on the Nagle timer.  This is equivalent to using k_ESteamNetworkingSend_Unreliable
		// and then immediately flushing the messages using ISteamNetworkingSockets::FlushMessagesOnConnection
		// or ISteamNetworkingMessages::FlushMessagesToUser.  (But using this flag is more efficient since you
		// only make one API call.)
		public const int k_nSteamNetworkingSend_UnreliableNoNagle = k_nSteamNetworkingSend_Unreliable|k_nSteamNetworkingSend_NoNagle;
		// If the message cannot be sent very soon (because the connection is still doing some initial
		// handshaking, route negotiations, etc), then just drop it.  This is only applicable for unreliable
		// messages.  Using this flag on reliable messages is invalid.
		public const int k_nSteamNetworkingSend_NoDelay = 4;
		// Send an unreliable message, but if it cannot be sent relatively quickly, just drop it instead of queuing it.
		// This is useful for messages that are not useful if they are excessively delayed, such as voice data.
		// NOTE: The Nagle algorithm is not used, and if the message is not dropped, any messages waiting on the
		// Nagle timer are immediately flushed.
		//
		// A message will be dropped under the following circumstances:
		// - the connection is not fully connected.  (E.g. the "Connecting" or "FindingRoute" states)
		// - there is a sufficiently large number of messages queued up already such that the current message
		//   will not be placed on the wire in the next ~200ms or so.
		//
		// If a message is dropped for these reasons, k_EResultIgnored will be returned.
		public const int k_nSteamNetworkingSend_UnreliableNoDelay = k_nSteamNetworkingSend_Unreliable|k_nSteamNetworkingSend_NoDelay|k_nSteamNetworkingSend_NoNagle;
		// Reliable message send. Can send up to k_cbMaxSteamNetworkingSocketsMessageSizeSend bytes in a single message.
		// Does fragmentation/re-assembly of messages under the hood, as well as a sliding window for
		// efficient sends of large chunks of data.
		//
		// The Nagle algorithm is used.  See notes on k_ESteamNetworkingSendType_Unreliable for more details.
		// See k_ESteamNetworkingSendType_ReliableNoNagle, ISteamNetworkingSockets::FlushMessagesOnConnection,
		// ISteamNetworkingMessages::FlushMessagesToUser
		//
		// Migration note: This is NOT the same as k_EP2PSendReliable, it's more like k_EP2PSendReliableWithBuffering
		public const int k_nSteamNetworkingSend_Reliable = 8;
		// Send a message reliably, but bypass Nagle's algorithm.
		//
		// Migration note: This is equivalent to k_EP2PSendReliable
		public const int k_nSteamNetworkingSend_ReliableNoNagle = k_nSteamNetworkingSend_Reliable|k_nSteamNetworkingSend_NoNagle;
		// By default, message sending is queued, and the work of encryption and talking to
		// the operating system sockets, etc is done on a service thread.  This is usually a
		// a performance win when messages are sent from the "main thread".  However, if this
		// flag is set, and data is ready to be sent immediately (either from this message
		// or earlier queued data), then that work will be done in the current thread, before
		// the current call returns.  If data is not ready to be sent (due to rate limiting
		// or Nagle), then this flag has no effect.
		//
		// This is an advanced flag used to control performance at a very low level.  For
		// most applications running on modern hardware with more than one CPU core, doing
		// the work of sending on a service thread will yield the best performance.  Only
		// use this flag if you have a really good reason and understand what you are doing.
		// Otherwise you will probably just make performance worse.
		public const int k_nSteamNetworkingSend_UseCurrentThread = 16;
		// When sending a message using ISteamNetworkingMessages, automatically re-establish
		// a broken session, without returning k_EResultNoConnection.  Without this flag,
		// if you attempt to send a message, and the session was proactively closed by the
		// peer, or an error occurred that disrupted communications, then you must close the
		// session using ISteamNetworkingMessages::CloseSessionWithUser before attempting to
		// send another message.  (Or you can simply add this flag and retry.)  In this way,
		// the disruption cannot go unnoticed, and a more clear order of events can be
		// ascertained. This is especially important when reliable messages are used, since
		// if the connection is disrupted, some of those messages will not have been delivered,
		// and it is in general not possible to know which.  Although a
		// SteamNetworkingMessagesSessionFailed_t callback will be posted when an error occurs
		// to notify you that a failure has happened, callbacks are asynchronous, so it is not
		// possible to tell exactly when it happened.  And because the primary purpose of
		// ISteamNetworkingMessages is to be like UDP, there is no notification when a peer closes
		// the session.
		//
		// If you are not using any reliable messages (e.g. you are using ISteamNetworkingMessages
		// exactly as a transport replacement for UDP-style datagrams only), you may not need to
		// know when an underlying connection fails, and so you may not need this notification.
		public const int k_nSteamNetworkingSend_AutoRestartBrokenSession = 32;
		/// Max possible length of a ping location, in string format.  This is
		/// an extremely conservative worst case value which leaves room for future
		/// syntax enhancements.  Most strings in practice are a lot shorter.
		/// If you are storing many of these, you will very likely benefit from
		/// using dynamic memory.
		public const int k_cchMaxSteamNetworkingPingLocationString = 1024;
		/// Special values that are returned by some functions that return a ping.
		public const int k_nSteamNetworkingPing_Failed = -1;
		public const int k_nSteamNetworkingPing_Unknown = -2;
		// Bitmask of types to share
		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Default = -1; // Special value - use user defaults
		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Disable = 0; // Do not do any ICE work at all or share any IP addresses with peer
		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Relay = 1; // Relayed connection via TURN server.
		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Private = 2; // host addresses that appear to be link-local or RFC1918 addresses
		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Public = 4; // STUN reflexive addresses, or host address that isn't a "private" address
		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_All = 0x7fffffff;
		public const ulong k_ulPartyBeaconIdInvalid = 0;
		public const int INVALID_HTTPREQUEST_HANDLE		= 0;
		public const int STEAM_INPUT_MAX_COUNT = 16;
		public const int STEAM_INPUT_MAX_ANALOG_ACTIONS = 16;
		public const int STEAM_INPUT_MAX_DIGITAL_ACTIONS = 128;
		public const int STEAM_INPUT_MAX_ORIGINS = 8;
		public const int STEAM_INPUT_MAX_ACTIVE_LAYERS = 16;
		// When sending an option to a specific controller handle, you can send to all devices via this command
		public const ulong STEAM_INPUT_HANDLE_ALL_CONTROLLERS = 0xFFFFFFFFFFFFFFFF;
		public const float STEAM_INPUT_MIN_ANALOG_ACTION_DATA = -1.0f;
		public const float STEAM_INPUT_MAX_ANALOG_ACTION_DATA = 1.0f;
		// maximum number of characters a lobby metadata key can be
		public const byte k_nMaxLobbyKeyLength = 255;
		public const int k_SteamMusicNameMaxLength = 255;
		public const int k_SteamMusicPNGMaxLength = 65535;
	}
}

#endif // !DISABLESTEAMWORKS
