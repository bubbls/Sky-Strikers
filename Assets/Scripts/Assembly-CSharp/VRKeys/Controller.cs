using UnityEngine;
using UnityEngine.XR;

namespace VRKeys
{
	public class Controller : MonoBehaviour
	{
		private Mallet mallet;

		private InputDeviceRole role;

		private InputDevice _device;

		private void Start()
		{
		}

		private InputDevice GetDevice()
		{
			return default(InputDevice);
		}

		private bool DeviceIsValid()
		{
			return false;
		}

		public void TriggerPulse()
		{
		}

		public bool OnGrip()
		{
			return false;
		}
	}
}
