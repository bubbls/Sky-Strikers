using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	public class JetstreamBallSuckerSoundPlayer : MonoBehaviour
	{
		[SerializeField]
		private AudioSource _suckingAudioSource;

		private SoundInfo _suckSfxNoBall;

		private SoundInfo _suckSfxWithBall;

		public void ConfigureSoundInfo(SoundInfo suckingNoBall, SoundInfo suckingWithBall)
		{
		}

		private void OnDisable()
		{
		}

		public void StopSounds()
		{
		}

		public void PlaySuckingSound(bool hasBall)
		{
		}
	}
}
