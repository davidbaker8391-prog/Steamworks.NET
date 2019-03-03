// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2018 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

#if UNITY_ANDROID || UNITY_IOS || UNITY_TIZEN || UNITY_TVOS || UNITY_WEBGL || UNITY_WSA || UNITY_PS4 || UNITY_WII || UNITY_XBOXONE || UNITY_SWITCH
	#define DISABLESTEAMWORKS
#endif

#if !DISABLESTEAMWORKS

using System.Runtime.InteropServices;
using IntPtr = System.IntPtr;

namespace Steamworks {
	public static class SteamController {
		/// <summary>
		/// <para> Init and Shutdown must be called when starting/ending use of this interface</para>
		/// </summary>
		public static bool Init() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_Init(CSteamAPIContext.GetSteamController());
		}

		public static bool Shutdown() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_Shutdown(CSteamAPIContext.GetSteamController());
		}

		/// <summary>
		/// <para> Synchronize API state with the latest Steam Controller inputs available. This</para>
		/// <para> is performed automatically by SteamAPI_RunCallbacks, but for the absolute lowest</para>
		/// <para> possible latency, you call this directly before reading controller state. This must</para>
		/// <para> be called from somewhere before GetConnectedControllers will return any handles</para>
		/// </summary>
		public static void RunFrame() {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_RunFrame(CSteamAPIContext.GetSteamController());
		}

		/// <summary>
		/// <para> Enumerate currently connected controllers</para>
		/// <para> handlesOut should point to a STEAM_CONTROLLER_MAX_COUNT sized array of ControllerHandle_t handles</para>
		/// <para> Returns the number of handles written to handlesOut</para>
		/// </summary>
		public static int GetConnectedControllers(ControllerHandle_t[] handlesOut) {
			InteropHelp.TestIfAvailableClient();
			if (handlesOut.Length != Constants.STEAM_CONTROLLER_MAX_COUNT) {
				throw new System.ArgumentException("handlesOut must be the same size as Constants.STEAM_CONTROLLER_MAX_COUNT!");
			}
			return NativeMethods.ISteamController_GetConnectedControllers(CSteamAPIContext.GetSteamController(), handlesOut);
		}

		/// <summary>
		/// <para>-----------------------------------------------------------------------------</para>
		/// <para> ACTION SETS</para>
		/// <para>-----------------------------------------------------------------------------</para>
		/// <para> Lookup the handle for an Action Set. Best to do this once on startup, and store the handles for all future API calls.</para>
		/// </summary>
		public static ControllerActionSetHandle_t GetActionSetHandle(string pszActionSetName) {
			InteropHelp.TestIfAvailableClient();
			using (var pszActionSetName2 = new InteropHelp.UTF8StringHandle(pszActionSetName)) {
				return (ControllerActionSetHandle_t)NativeMethods.ISteamController_GetActionSetHandle(CSteamAPIContext.GetSteamController(), pszActionSetName2);
			}
		}

		/// <summary>
		/// <para> Reconfigure the controller to use the specified action set (ie 'Menu', 'Walk' or 'Drive')</para>
		/// <para> This is cheap, and can be safely called repeatedly. It's often easier to repeatedly call it in</para>
		/// <para> your state loops, instead of trying to place it in all of your state transitions.</para>
		/// </summary>
		public static void ActivateActionSet(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_ActivateActionSet(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetHandle);
		}

		public static ControllerActionSetHandle_t GetCurrentActionSet(ControllerHandle_t controllerHandle) {
			InteropHelp.TestIfAvailableClient();
			return (ControllerActionSetHandle_t)NativeMethods.ISteamController_GetCurrentActionSet(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		/// <summary>
		/// <para> ACTION SET LAYERS</para>
		/// </summary>
		public static void ActivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_ActivateActionSetLayer(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetLayerHandle);
		}

		public static void DeactivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_DeactivateActionSetLayer(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetLayerHandle);
		}

		public static void DeactivateAllActionSetLayers(ControllerHandle_t controllerHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_DeactivateAllActionSetLayers(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		public static int GetActiveActionSetLayers(ControllerHandle_t controllerHandle, out ControllerActionSetHandle_t handlesOut) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetActiveActionSetLayers(CSteamAPIContext.GetSteamController(), controllerHandle, out handlesOut);
		}

		/// <summary>
		/// <para>-----------------------------------------------------------------------------</para>
		/// <para> ACTIONS</para>
		/// <para>-----------------------------------------------------------------------------</para>
		/// <para> Lookup the handle for a digital action. Best to do this once on startup, and store the handles for all future API calls.</para>
		/// </summary>
		public static ControllerDigitalActionHandle_t GetDigitalActionHandle(string pszActionName) {
			InteropHelp.TestIfAvailableClient();
			using (var pszActionName2 = new InteropHelp.UTF8StringHandle(pszActionName)) {
				return (ControllerDigitalActionHandle_t)NativeMethods.ISteamController_GetDigitalActionHandle(CSteamAPIContext.GetSteamController(), pszActionName2);
			}
		}

		/// <summary>
		/// <para> Returns the current state of the supplied digital game action</para>
		/// </summary>
		public static ControllerDigitalActionData_t GetDigitalActionData(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetDigitalActionData(CSteamAPIContext.GetSteamController(), controllerHandle, digitalActionHandle);
		}

		/// <summary>
		/// <para> Get the origin(s) for a digital action within an action set. Returns the number of origins supplied in originsOut. Use this to display the appropriate on-screen prompt for the action.</para>
		/// <para> originsOut should point to a STEAM_CONTROLLER_MAX_ORIGINS sized array of EControllerActionOrigin handles. The EControllerActionOrigin enum will get extended as support for new controller controllers gets added to</para>
		/// <para> the Steam client and will exceed the values from this header, please check bounds if you are using a look up table.</para>
		/// </summary>
		public static int GetDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, EControllerActionOrigin[] originsOut) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetDigitalActionOrigins(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetHandle, digitalActionHandle, originsOut);
		}

		/// <summary>
		/// <para> Lookup the handle for an analog action. Best to do this once on startup, and store the handles for all future API calls.</para>
		/// </summary>
		public static ControllerAnalogActionHandle_t GetAnalogActionHandle(string pszActionName) {
			InteropHelp.TestIfAvailableClient();
			using (var pszActionName2 = new InteropHelp.UTF8StringHandle(pszActionName)) {
				return (ControllerAnalogActionHandle_t)NativeMethods.ISteamController_GetAnalogActionHandle(CSteamAPIContext.GetSteamController(), pszActionName2);
			}
		}

		/// <summary>
		/// <para> Returns the current state of these supplied analog game action</para>
		/// </summary>
		public static ControllerAnalogActionData_t GetAnalogActionData(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetAnalogActionData(CSteamAPIContext.GetSteamController(), controllerHandle, analogActionHandle);
		}

		/// <summary>
		/// <para> Get the origin(s) for an analog action within an action set. Returns the number of origins supplied in originsOut. Use this to display the appropriate on-screen prompt for the action.</para>
		/// <para> originsOut should point to a STEAM_CONTROLLER_MAX_ORIGINS sized array of EControllerActionOrigin handles. The EControllerActionOrigin enum will get extended as support for new controller controllers gets added to</para>
		/// <para> the Steam client and will exceed the values from this header, please check bounds if you are using a look up table.</para>
		/// </summary>
		public static int GetAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, EControllerActionOrigin[] originsOut) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetAnalogActionOrigins(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetHandle, analogActionHandle, originsOut);
		}

		/// <summary>
		/// <para> Get a local path to art for on-screen glyph for a particular origin - this call is cheap</para>
		/// </summary>
		public static string GetGlyphForActionOrigin(EControllerActionOrigin eOrigin) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamController_GetGlyphForActionOrigin(CSteamAPIContext.GetSteamController(), eOrigin));
		}

		/// <summary>
		/// <para> Returns a localized string (from Steam's language setting) for the specified origin - this call is serialized</para>
		/// </summary>
		public static string GetStringForActionOrigin(EControllerActionOrigin eOrigin) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamController_GetStringForActionOrigin(CSteamAPIContext.GetSteamController(), eOrigin));
		}

		public static void StopAnalogActionMomentum(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_StopAnalogActionMomentum(CSteamAPIContext.GetSteamController(), controllerHandle, eAction);
		}

		/// <summary>
		/// <para> Returns raw motion data from the specified controller</para>
		/// </summary>
		public static ControllerMotionData_t GetMotionData(ControllerHandle_t controllerHandle) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetMotionData(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		/// <summary>
		/// <para>-----------------------------------------------------------------------------</para>
		/// <para> OUTPUTS</para>
		/// <para>-----------------------------------------------------------------------------</para>
		/// <para> Trigger a haptic pulse on a controller</para>
		/// </summary>
		public static void TriggerHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_TriggerHapticPulse(CSteamAPIContext.GetSteamController(), controllerHandle, eTargetPad, usDurationMicroSec);
		}

		/// <summary>
		/// <para> Trigger a pulse with a duty cycle of usDurationMicroSec / usOffMicroSec, unRepeat times.</para>
		/// <para> nFlags is currently unused and reserved for future use.</para>
		/// </summary>
		public static void TriggerRepeatedHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_TriggerRepeatedHapticPulse(CSteamAPIContext.GetSteamController(), controllerHandle, eTargetPad, usDurationMicroSec, usOffMicroSec, unRepeat, nFlags);
		}

		/// <summary>
		/// <para> Trigger a vibration event on supported controllers.</para>
		/// </summary>
		public static void TriggerVibration(ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_TriggerVibration(CSteamAPIContext.GetSteamController(), controllerHandle, usLeftSpeed, usRightSpeed);
		}

		/// <summary>
		/// <para> Set the controller LED color on supported controllers.</para>
		/// </summary>
		public static void SetLEDColor(ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_SetLEDColor(CSteamAPIContext.GetSteamController(), controllerHandle, nColorR, nColorG, nColorB, nFlags);
		}

		/// <summary>
		/// <para>-----------------------------------------------------------------------------</para>
		/// <para> Utility functions availible without using the rest of Steam Input API</para>
		/// <para>-----------------------------------------------------------------------------</para>
		/// <para> Invokes the Steam overlay and brings up the binding screen if the user is using Big Picture Mode</para>
		/// <para> If the user is not in Big Picture Mode it will open up the binding in a new window</para>
		/// </summary>
		public static bool ShowBindingPanel(ControllerHandle_t controllerHandle) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_ShowBindingPanel(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		/// <summary>
		/// <para> Returns the input type for a particular handle</para>
		/// </summary>
		public static ESteamInputType GetInputTypeForHandle(ControllerHandle_t controllerHandle) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetInputTypeForHandle(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		/// <summary>
		/// <para> Returns the associated controller handle for the specified emulated gamepad - can be used with the above 2 functions</para>
		/// <para> to identify controllers presented to your game over Xinput. Returns 0 if the Xinput index isn't associated with Steam Input</para>
		/// </summary>
		public static ControllerHandle_t GetControllerForGamepadIndex(int nIndex) {
			InteropHelp.TestIfAvailableClient();
			return (ControllerHandle_t)NativeMethods.ISteamController_GetControllerForGamepadIndex(CSteamAPIContext.GetSteamController(), nIndex);
		}

		/// <summary>
		/// <para> Returns the associated gamepad index for the specified controller, if emulating a gamepad or -1 if not associated with an Xinput index</para>
		/// </summary>
		public static int GetGamepadIndexForController(ControllerHandle_t ulControllerHandle) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetGamepadIndexForController(CSteamAPIContext.GetSteamController(), ulControllerHandle);
		}

		/// <summary>
		/// <para> Returns a localized string (from Steam's language setting) for the specified Xbox controller origin. This function is cheap.</para>
		/// </summary>
		public static string GetStringForXboxOrigin(EXboxOrigin eOrigin) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamController_GetStringForXboxOrigin(CSteamAPIContext.GetSteamController(), eOrigin));
		}

		/// <summary>
		/// <para> Get a local path to art for on-screen glyph for a particular Xbox controller origin. This function is serialized.</para>
		/// </summary>
		public static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamController_GetGlyphForXboxOrigin(CSteamAPIContext.GetSteamController(), eOrigin));
		}

		/// <summary>
		/// <para> Get the equivalent ActionOrigin for a given Xbox controller origin this can be chained with GetGlyphForActionOrigin to provide future proof glyphs for</para>
		/// <para> non-Steam Input API action games. Note - this only translates the buttons directly and doesn't take into account any remapping a user has made in their configuration</para>
		/// </summary>
		public static EControllerActionOrigin GetActionOriginFromXboxOrigin(ControllerHandle_t controllerHandle, EXboxOrigin eOrigin) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetActionOriginFromXboxOrigin(CSteamAPIContext.GetSteamController(), controllerHandle, eOrigin);
		}

		/// <summary>
		/// <para> Convert an origin to another controller type - for inputs not present on the other controller type this will return k_EControllerActionOrigin_None</para>
		/// </summary>
		public static EControllerActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EControllerActionOrigin eSourceOrigin) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_TranslateActionOrigin(CSteamAPIContext.GetSteamController(), eDestinationInputType, eSourceOrigin);
		}
	}
}

#endif // !DISABLESTEAMWORKS
