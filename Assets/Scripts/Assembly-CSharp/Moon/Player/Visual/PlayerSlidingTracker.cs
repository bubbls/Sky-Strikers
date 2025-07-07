using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class PlayerSlidingTracker : MonoBehaviour
	{
		[SerializeField]
		private float _slideThreshold;

		[SerializeField]
		private Vector2 _slidingFadeInRange;

		[SerializeField]
		private float _fadeOutTime;

		[SerializeField]
		private float _delayBetweenSlideStart;

		[SerializeField]
		private PlayerVisualsVelocityTracker _velocityTracker;

		[SerializeField]
		private PlayerGroundedChecker _groundedChecker;

		private AudioSource _slidingSfxAudioSource;

		private Vector3 _curHorizontalVelocity;

		private float _curHorizontalVelocityMagnitude;

		private SoundInfo _slidingStartSfx;

		private SoundInfo _slidingSfx;

		private float _lastSlideStopTime;

		private int _slidingSoundStartId;

		private int _slidingSoundId;

		private bool _canTrack;

		public void Disable()
		{
		}

		public void Configure(SoundInfo slidingStartSoundInfo, SoundInfo slidingSoundInfo)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDisable()
		{
		}

		private void SlideCheck()
		{
		}

		private void TryToggleSlidingSfx(bool shouldPlay)
		{
		}

		private void StopSlidingSfx()
		{
		}
	}
}
