// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2014 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamUnifiedMessages {
		// Sends a service method (in binary serialized form) using the Steam Client.
		// Returns a unified message handle (k_InvalidUnifiedMessageHandle if could not send the message).
		public static ClientUnifiedMessageHandle SendMethod(string pchServiceMethod, IntPtr pRequestBuffer, uint unRequestBufferSize, ulong unContext) {
			InteropHelp.TestIfAvailableClient();
			return (ClientUnifiedMessageHandle)NativeMethods.ISteamUnifiedMessages_SendMethod(new InteropHelp.UTF8String(pchServiceMethod), pRequestBuffer, unRequestBufferSize, unContext);
		}

		// Gets the size of the response and the EResult. Returns false if the response is not ready yet.
		public static bool GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUnifiedMessages_GetMethodResponseInfo(hHandle, out punResponseSize, out peResult);
		}

		// Gets a response in binary serialized form (and optionally release the corresponding allocated memory).
		public static bool GetMethodResponseData(ClientUnifiedMessageHandle hHandle, IntPtr pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUnifiedMessages_GetMethodResponseData(hHandle, pResponseBuffer, unResponseBufferSize, bAutoRelease);
		}

		// Releases the message and its corresponding allocated memory.
		public static bool ReleaseMethod(ClientUnifiedMessageHandle hHandle) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUnifiedMessages_ReleaseMethod(hHandle);
		}

		// Sends a service notification (in binary serialized form) using the Steam Client.
		// Returns true if the notification was sent successfully.
		public static bool SendNotification(string pchServiceNotification, IntPtr pNotificationBuffer, uint unNotificationBufferSize) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUnifiedMessages_SendNotification(new InteropHelp.UTF8String(pchServiceNotification), pNotificationBuffer, unNotificationBufferSize);
		}
	}
}