using UnityEngine;

namespace Moon.Bootstrap
{
	public static class ApplicationConfigurator
	{
		private const bool ForceDedicatedServerMode = false;

		public static bool AllowEffects => false;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void ConfigureForCurrentPlatform()
		{
		}

		public static bool IsDedicatedServer()
		{
			return false;
		}

		private static void InitializePlatformRuntimeData()
		{
		}
	}
}
