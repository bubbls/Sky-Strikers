using System.Text;
using AOT;
using Steamworks;
using UnityEngine;

namespace Chamber8.Framework.Steam
{
	[DisallowMultipleComponent]
	public class SteamManager : MonoBehaviour
	{
		protected static bool s_EverInitialized;

		protected static SteamManager s_instance;

		protected bool m_bInitialized;

		protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

		public static SteamManager Instance => null;

		public static bool Initialized => false;

		[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
		protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitOnPlayMode()
		{
		}

		public virtual void Initialize(uint steamAppId)
		{
		}

		private void SetUpCallbacks()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void Update()
		{
		}
	}
}
