using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaEyePumpkinBouncerSoundTrigger : MonoBehaviour
	{
		[SerializeField]
		private bool _useLayerMask;

		[SerializeField]
		private SoundPlayerStub _soundPlayerStub;

		public void StopSounds()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
