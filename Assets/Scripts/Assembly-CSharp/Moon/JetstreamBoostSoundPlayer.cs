using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon
{
	public class JetstreamBoostSoundPlayer : MonoBehaviour
	{
		[SerializeField]
		private SoundInfo _startSound;

		[SerializeField]
		[Space(5f)]
		private SoundInfo _middleSound;

		[SerializeField]
		private float _middleSoundFadeIn;

		[SerializeField]
		private float _middleSoundFadeOut;

		[SerializeField]
		[Space(5f)]
		private SoundInfo _stopSound;

		private int _startStopId;

		private int _middleSoundId;

		private bool _isSequencePlaying;

		private AudioSource _startStopAudioSource;

		private AudioSource _middleSoundAudioSource;

		private Vector3 _targetPosition;

		private Quaternion _targetRotation;

		private Transform _transform;

		public void Configure(SoundInfo startSfx, SoundInfo middleSfx, SoundInfo endSfx)
		{
		}

		public void PlaySoundSequence()
		{
		}

		public void FinishSoundSequence()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		public void StopInstantly()
		{
		}

		private void StopSound(ref int id, out AudioSource audioSource)
		{
			audioSource = null;
		}
	}
}
