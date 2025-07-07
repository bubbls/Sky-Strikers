using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.Bootstrap
{
	[DefaultExecutionOrder(-50)]
	public class ServiceInitializer : MonoBehaviour
	{
		private const string MixpanelRuntimeToken = "dc7a963edc01f434a0cce69769bc07ec";

		private const string MixpanelDebugToken = "0dda7b6e6cbe4e1905745021ce3e875d";

		private void Awake()
		{
		}

		private static string StripToken(string token)
		{
			return null;
		}

		private static void InitializeMixpanelToken()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void SessionStart()
		{
		}

		private void SessionEnd()
		{
		}

		private void OnDestroy()
		{
		}

		private static string WrapMessageInternal(string message, L.LogLevel logLevel)
		{
			return null;
		}
	}
}
