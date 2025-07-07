using System;
using System.Net;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using DG.Tweening;
using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using Moon.Leaderboard;
using NaughtyAttributes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Mission
{
	public class MissionBoard : MissionUIBase
	{
		private class MissionBoardSaveData
		{
			public bool ContractAccepted;
		}

		private const string LoadingTextFetching = "FETCHING...";

		private const string LoadingTextClaiming = "CLAIMING...";

		private const string MissionBoardKey = "MissionBoard";

		[SerializeField]
		private MissionTable _missionTable;

		[Header("Contract")]
		[SerializeField]
		private GameObject _contractPage;

		[SerializeField]
		private Animator _effectAnimator;

		[SerializeField]
		private SoundInfo _sfxTurnOnMonitor;

		private static readonly int _turnOff;

		private static readonly int _turnOn;

		[SerializeField]
		private MissionBoardItemUI _missionItemPrefab;

		[Header("Main Board")]
		[SerializeField]
		private TMP_Text _timeText;

		[SerializeField]
		private Image _timerFillImage;

		[Header("Panels")]
		[SerializeField]
		private MissionBoardLoadingPanel _loadingPanel;

		[SerializeField]
		private MissionBoardItemsPanel _itemsPanel;

		[SerializeField]
		private MissionBoardErrorInfoPanel _errorInfoPanel;

		[SerializeField]
		private ClaimRewardPanel _claimRewardPanel;

		private IMessageSubscriber _subscriber;

		private readonly int _oneDayTotalMinutesAmount;

		private int _remainingHours;

		private int _remainingMinutes;

		private bool _initialized;

		private readonly Cooldown _cooldown;

		private Sequence _sequence;

		private DateTime? _dueTime;

		private int _refreshCookie;

		private int _claimCookie;

		public bool HasMissionAccomplished => false;

		public bool HasMissionNotFinished => false;

		public override bool IsOn => false;

		public event Action<MissionTable> RequestMission
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public override void ToggleUI(bool enable)
		{
		}

		private static bool IsContractAccepted()
		{
			return false;
		}

		private IMissionItemUI SpawnItem(Transform spawnPoint)
		{
			return null;
		}

		private int HandlePlayerStatisticsUpdated(IMessage<PlayerStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		public void RefreshMissions()
		{
		}

		public void NotifyMissionRefreshed(MissionTable missionTable)
		{
		}

		public void UpdateMissions()
		{
		}

		public void SetBroken(HttpStatusCode errorCode, string errorMessage)
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void PlayAcceptAnimation()
		{
		}

		public void ClaimReward(Action<ClaimRewardResult> onComplete)
		{
		}

		private void LateUpdate()
		{
		}

		public void Prefetch()
		{
		}
	}
}
