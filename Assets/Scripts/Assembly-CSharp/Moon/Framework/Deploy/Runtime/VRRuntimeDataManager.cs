using UnityEngine;

namespace Moon.Framework.Deploy.Runtime
{
	public class VRRuntimeDataManager
	{
		private static readonly VRRuntimeDataManager _instance;

		private static bool IsInitialized;

		public static VRRuntimeDataManager Instance => null;

		public VRRuntimeData RuntimeData { get; private set; }

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void TryInitializeInstance()
		{
		}

		private void Initialize()
		{
		}

		private void LoadRuntimeData()
		{
		}
	}
}
