using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DG.Tweening;
using Moon.Analytics;
using Moon.Economy;
using TMPro;
using UnityEngine;

namespace Moon.Mission
{
	public class ClaimRewardPanel : MissionUIBase
	{
		[SerializeField]
		private GameObject _rewardGroup;

		[SerializeField]
		private TMP_Text _activityRewardText;

		[SerializeField]
		private TMP_Text _freeCurrencyRewardText;

		[SerializeField]
		private TMP_Text _missionInfoText;

		[SerializeField]
		private GameObject _activityRewardVisual;

		private bool _isClaimingReward;

		private MissionService _missionService;

		private PlayerEconomy _playerEconomy;

		private readonly HashSet<MissionRecord> _accomplishedMissions;

		private MissionTable _missionTable;

		private const float ResetMissionDisplayInfoDuration = 3f;

		private Sequence _sequence;

		private int _claimableAmount;

		private int _missionInProgressAmount;

		private static readonly Regex _tierRegex;

		public bool HasMissionAccomplished => false;

		public bool HasMissionNotFinished => false;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void ClaimReward(Action<ClaimRewardResult> onComplete)
		{
		}

		private void ResetClaimResult()
		{
		}

		private void SetClaimResult(string result)
		{
		}

		public void UpdateMissions(List<MissionRecord> missions)
		{
		}

		private static List<AnalyticsHelper.TierObject> CreateTierObjectList(IEnumerable<MissionRecord> accomplished)
		{
			return null;
		}

		private static int GetProgressionTier(MissionTable missionTable)
		{
			return 0;
		}

		private static int GetTierFromName(string name)
		{
			return 0;
		}
	}
}
