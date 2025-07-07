using PlayFab.Internal;
using UnityEngine;

namespace Moon.Bootstrap
{
	public class DebugConfigurator : SingletonMonoBehaviour<DebugConfigurator>
	{
		[SerializeField]
		private bool displayPlayerInfo;

		[SerializeField]
		private bool debugBatTracking;

		[SerializeField]
		private bool debugStatNotUpload;

		public bool DisplayPlayerInfo => false;

		public bool DebugBatTracking => false;

		public bool DebugStatNotUpload => false;
	}
}
