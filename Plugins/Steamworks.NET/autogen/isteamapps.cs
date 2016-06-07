// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2015 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamApps {
		public static bool BIsSubscribed() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsSubscribed();
		}

		public static bool BIsLowViolence() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsLowViolence();
		}

		public static bool BIsCybercafe() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsCybercafe();
		}

		public static bool BIsVACBanned() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsVACBanned();
		}

		public static string GetCurrentGameLanguage() {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetCurrentGameLanguage());
		}

		public static string GetAvailableGameLanguages() {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetAvailableGameLanguages());
		}

		/// <summary>
		/// <para> only use this member if you need to check ownership of another game related to yours, a demo for example</para>
		/// </summary>
		public static bool BIsSubscribedApp(AppId_t appID) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsSubscribedApp(appID);
		}

		/// <summary>
		/// <para> Takes AppID of DLC and checks if the user owns the DLC &amp; if the DLC is installed</para>
		/// </summary>
		public static bool BIsDlcInstalled(AppId_t appID) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsDlcInstalled(appID);
		}

		/// <summary>
		/// <para> returns the Unix time of the purchase of the app</para>
		/// </summary>
		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetEarliestPurchaseUnixTime(nAppID);
		}

		/// <summary>
		/// <para> Checks if the user is subscribed to the current app through a free weekend</para>
		/// <para> This function will return false for users who have a retail or other type of license</para>
		/// <para> Before using, please ask your Valve technical contact how to package and secure your free weekened</para>
		/// </summary>
		public static bool BIsSubscribedFromFreeWeekend() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsSubscribedFromFreeWeekend();
		}

		/// <summary>
		/// <para> Returns the number of DLC pieces for the running app</para>
		/// </summary>
		public static int GetDLCCount() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetDLCCount();
		}

		/// <summary>
		/// <para> Returns metadata for DLC by index, of range [0, GetDLCCount()]</para>
		/// </summary>
		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchName2 = Marshal.AllocHGlobal(cchNameBufferSize);
			bool ret = NativeMethods.ISteamApps_BGetDLCDataByIndex(iDLC, out pAppID, out pbAvailable, pchName2, cchNameBufferSize);
			pchName = ret ? InteropHelp.PtrToStringUTF8(pchName2) : null;
			Marshal.FreeHGlobal(pchName2);
			return ret;
		}

		/// <summary>
		/// <para> Install/Uninstall control for optional DLC</para>
		/// </summary>
		public static void InstallDLC(AppId_t nAppID) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamApps_InstallDLC(nAppID);
		}

		public static void UninstallDLC(AppId_t nAppID) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamApps_UninstallDLC(nAppID);
		}

		/// <summary>
		/// <para> Request legacy cd-key for yourself or owned DLC. If you are interested in this</para>
		/// <para> data then make sure you provide us with a list of valid keys to be distributed</para>
		/// <para> to users when they purchase the game, before the game ships.</para>
		/// <para> You'll receive an AppProofOfPurchaseKeyResponse_t callback when</para>
		/// <para> the key is available (which may be immediately).</para>
		/// </summary>
		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamApps_RequestAppProofOfPurchaseKey(nAppID);
		}

		/// <summary>
		/// <para> returns current beta branch name, 'public' is the default branch</para>
		/// </summary>
		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchName2 = Marshal.AllocHGlobal(cchNameBufferSize);
			bool ret = NativeMethods.ISteamApps_GetCurrentBetaName(pchName2, cchNameBufferSize);
			pchName = ret ? InteropHelp.PtrToStringUTF8(pchName2) : null;
			Marshal.FreeHGlobal(pchName2);
			return ret;
		}

		/// <summary>
		/// <para> signal Steam that game files seems corrupt or missing</para>
		/// </summary>
		public static bool MarkContentCorrupt(bool bMissingFilesOnly) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_MarkContentCorrupt(bMissingFilesOnly);
		}

		/// <summary>
		/// <para> return installed depots in mount order</para>
		/// </summary>
		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetInstalledDepots(appID, pvecDepots, cMaxDepots);
		}

		/// <summary>
		/// <para> returns current app install folder for AppID, returns folder name length</para>
		/// </summary>
		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchFolder2 = Marshal.AllocHGlobal((int)cchFolderBufferSize);
			uint ret = NativeMethods.ISteamApps_GetAppInstallDir(appID, pchFolder2, cchFolderBufferSize);
			pchFolder = ret != 0 ? InteropHelp.PtrToStringUTF8(pchFolder2) : null;
			Marshal.FreeHGlobal(pchFolder2);
			return ret;
		}

		/// <summary>
		/// <para> returns true if that app is installed (not necessarily owned)</para>
		/// </summary>
		public static bool BIsAppInstalled(AppId_t appID) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsAppInstalled(appID);
		}

		/// <summary>
		/// <para> returns the SteamID of the original owner. If different from current user, it's borrowed</para>
		/// </summary>
		public static CSteamID GetAppOwner() {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamApps_GetAppOwner();
		}

		/// <summary>
		/// <para> Returns the associated launch param if the game is run via steam://run/&lt;appid&gt;//?param1=value1;param2=value2;param3=value3 etc.</para>
		/// <para> Parameter names starting with the character '@' are reserved for internal use and will always return and empty string.</para>
		/// <para> Parameter names starting with an underscore '_' are reserved for steam features -- they can be queried by the game,</para>
		/// <para> but it is advised that you not param names beginning with an underscore for your own features.</para>
		/// </summary>
		public static string GetLaunchQueryParam(string pchKey) {
			InteropHelp.TestIfAvailableClient();
			using (var pchKey2 = new InteropHelp.UTF8StringHandle(pchKey)) {
				return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetLaunchQueryParam(pchKey2));
			}
		}

		/// <summary>
		/// <para> get download progress for optional DLC</para>
		/// </summary>
		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetDlcDownloadProgress(nAppID, out punBytesDownloaded, out punBytesTotal);
		}

		/// <summary>
		/// <para> return the buildid of this app, may change at any time based on backend updates to the game</para>
		/// </summary>
		public static int GetAppBuildId() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetAppBuildId();
		}

		/// <summary>
		/// <para> Request all proof of purchase keys for the calling appid and asociated DLC.</para>
		/// <para> A series of AppProofOfPurchaseKeyResponse_t callbacks will be sent with</para>
		/// <para> appropriate appid values, ending with a final callback where the m_nAppId</para>
		/// <para> member is k_uAppIdInvalid (zero).</para>
		/// </summary>
		public static void RequestAllProofOfPurchaseKeys() {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamApps_RequestAllProofOfPurchaseKeys();
		}
	}
}