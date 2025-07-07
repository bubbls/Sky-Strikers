using System;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Leaderboard
{
	public class LevelUpEffects : MonoBehaviour
	{
		[SerializeField]
		private GameObject _idleParticles;

		[SerializeField]
		private GameObject _levelUpInProgressParticles;

		[SerializeField]
		private GameObject _levelUpFinishedParticles;

		private Animator _animator;

		private Action _levelUpFinishedCallback;

		private SoundPlayerStub _soundPlayerStub;

		public void Initialize()
		{
		}

		public void MoveDown()
		{
		}

		private void OnMoveDownEndListener()
		{
		}

		public void PlayTopUpBarSfx()
		{
		}

		public void PlayLevelUpInProgressEfx(float animSpeed)
		{
		}

		public void PlayLevelUpEndEfx(float animSpeed, Action callback)
		{
		}

		public void MoveUp()
		{
		}

		private void PlayLevelUpFinishedParticleListener()
		{
		}

		private void OnLevelUpFinishedEndListener()
		{
		}
	}
}
