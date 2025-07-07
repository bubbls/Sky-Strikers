using System;
using System.Runtime.CompilerServices;

namespace Moon.XRSystem
{
	public static class Utils
	{
		public struct UserInfo
		{
			public string DisplayName;
		}

		private static readonly UserInfo DefaultUserInfo;

		public static bool IsPico => false;

		public static bool IsOculus => false;

		public static bool IsOpenXR => false;

		public static bool IsSteam => false;

		public static bool IsSimulator => false;

		public static bool HasInputFocus { get; private set; }

		public static event Action<bool> OnInputFocusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void XRInitializeServices()
		{
		}

		public static bool IsPico4OrNewer()
		{
			return false;
		}

		public static void XRRequestCurrentUserInfo(Action<UserInfo> complete)
		{
		}

		private static void TrackAppFocus()
		{
		}

		public static bool IsValveIndex()
		{
			return false;
		}
	}
}
