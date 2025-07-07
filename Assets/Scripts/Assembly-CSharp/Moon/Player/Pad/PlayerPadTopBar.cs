using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadTopBar : MonoBehaviour
	{
		[SerializeField]
		private PlayerPadConnectionStatus _connectionStatus;

		[SerializeField]
		private PlayerPadTime _time;

		[SerializeField]
		private PlayerPadBatteryLevel _batteryLevel;

		private bool _batteryEnabled;

		private bool _isInitialized;

		public void Initialize()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnEnable()
		{
		}
	}
}
