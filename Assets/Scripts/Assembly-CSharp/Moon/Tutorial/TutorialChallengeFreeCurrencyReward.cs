using DG.Tweening;
using DP.Takeaway.Sound;
using PlayFab;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialChallengeFreeCurrencyReward : MonoBehaviour
	{
		private enum FreeCurrencyRewardId
		{
			ShootMovingTargetsReward = 0,
			RunningTrackReward = 1,
			Shoot6RingGoalsReward = 2,
			RandomReward001 = 3,
			RandomReward002 = 4,
			BasicJump_0 = 10,
			BasicJump_1 = 11,
			BasicJump_2 = 12,
			PoleJump_0 = 20,
			PoleJump_1 = 21,
			PoleJump_2 = 22,
			ParalleWallJump_0 = 30,
			ParalleWallJump_1 = 31,
			ParkourPark_0 = 40,
			ParkourPark_1 = 41,
			ParkourPark_2 = 42,
			ParkourPark_3 = 43,
			ParkourPark_4 = 44,
			ParkourPark_5 = 45,
			ParkourPark_6 = 46,
			ParkourPark_7 = 47,
			ParkourPark_8 = 48,
			ParkourPark_9 = 49
		}

		[SerializeField]
		private FreeCurrencyRewardId _freeCurrencyRewardId;

		[SerializeField]
		private Hittable _hittable;

		[SerializeField]
		private int _rewardAmount;

		[Header("VFX")]
		[SerializeField]
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnHit(MHitter hitter, HittableHitInfo hitinfo)
		{
		}
	}
}
