using UnityEngine;

namespace Moon
{
	public class FreeCamSettingsController : MonoBehaviour
	{
		[SerializeField]
		private FreeCamSettings _freeCamSettings;

		private string _freeCamSettingsPath;

		private bool _isInitialized;

		public FreeCamSettings FreeCamSettings => null;

		public void Initialize()
		{
		}

		public FreeCamSettings ReloadSettings()
		{
			return null;
		}

		private FreeCamSettings GenerateDefaultPCSettings()
		{
			return null;
		}
	}
}
