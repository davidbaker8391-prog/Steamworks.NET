// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2014 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamGameServerStats {
		// downloads stats for the user
		// returns a GSStatsReceived_t callback when completed
		// if the user has no stats, GSStatsReceived_t.m_eResult will be set to k_EResultFail
		// these stats will only be auto-updated for clients playing on the server. For other
		// users you'll need to call RequestUserStats() again to refresh any data
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser) {
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerStats_RequestUserStats(steamIDUser);
		}

		// requests stat information for a user, usable after a successful call to RequestUserStats()
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerStats_GetUserStat(steamIDUser, new InteropHelp.UTF8String(pchName), out pData);
		}

		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerStats_GetUserStat_(steamIDUser, new InteropHelp.UTF8String(pchName), out pData);
		}

		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerStats_GetUserAchievement(steamIDUser, new InteropHelp.UTF8String(pchName), out pbAchieved);
		}

		// Set / update stats and achievements.
		// Note: These updates will work only on stats game servers are allowed to edit and only for
		// game servers that have been declared as officially controlled by the game creators.
		// Set the IP range of your official servers on the Steamworks page
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerStats_SetUserStat(steamIDUser, new InteropHelp.UTF8String(pchName), nData);
		}

		public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerStats_SetUserStat_(steamIDUser, new InteropHelp.UTF8String(pchName), fData);
		}

		public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerStats_UpdateUserAvgRateStat(steamIDUser, new InteropHelp.UTF8String(pchName), flCountThisSession, dSessionLength);
		}

		public static bool SetUserAchievement(CSteamID steamIDUser, string pchName) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerStats_SetUserAchievement(steamIDUser, new InteropHelp.UTF8String(pchName));
		}

		public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName) {
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerStats_ClearUserAchievement(steamIDUser, new InteropHelp.UTF8String(pchName));
		}

		// Store the current data on the server, will get a GSStatsStored_t callback when set.
		//
		// If the callback has a result of k_EResultInvalidParam, one or more stats
		// uploaded has been rejected, either because they broke constraints
		// or were out of date. In this case the server sends back updated values.
		// The stats should be re-iterated to keep in sync.
		public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser) {
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerStats_StoreUserStats(steamIDUser);
		}
	}
}