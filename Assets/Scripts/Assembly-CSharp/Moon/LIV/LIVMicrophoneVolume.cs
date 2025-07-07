using Liv.Lck;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.LIV
{
	public class LIVMicrophoneVolume : MonoBehaviour
	{
		[SerializeField]
		private Image _microphoneVolumeImage;

		private float _incomingVolume;

		private LckService _lckService;

		public void Initialize(LckService lckService)
		{
		}

		private void Update()
		{
		}
	}
}
