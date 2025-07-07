using DG.Tweening;
using DP.Takeaway.Game;
using DP.Takeaway.Sound;
using PlayFab;
using UnityEngine;

namespace Moon.InGameActivity
{
	public class InGameActivityReward : MonoBehaviour
	{
		private enum InGameActivityRewardId
		{
			ChristmasIceBallReward = 0
		}

		[SerializeField]
		private Trigger _trigger;

		[SerializeField]
		private InGameActivityRewardId _freeCurrencyRewardId;

		[SerializeField]
		private int _rewardAmount;

		[SerializeField]
		[Header("VFX")]
		private GameObject _vfxGameObject;

		[Header("Sound")]
		[SerializeField]
		private SoundInfo _pickupSoundInfo;

		[Header("Animation Config")]
		[SerializeField]
		private Transform _visualTransform;

		[SerializeField]
		private float _animationDuration;

		[SerializeField]
		private float _endYValue;

		[SerializeField]
		private float _rotateAngle;

		private const string TutorialChallengeRewardFriendlyId = "com.chamber8.skystrikersvr.tutorialchallengereward";

		private PlayFabEconomyInstanceAPI _economyInstanceAPI;

		private Sequence _sequence;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnTriggerEnter(Collider other)
		{
		}

		public void TryEnableChallengeFreeCurrencyReward()
		{
		}

		private void KillSequence()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
