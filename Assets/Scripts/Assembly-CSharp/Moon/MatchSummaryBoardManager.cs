using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DG.Tweening;
using Moon.Arena;
using Moon.Leaderboard;
using Moon.PlayerProfile;
using UnityEngine;

namespace Moon
{
	public class MatchSummaryBoardManager : MonoBehaviour
	{
		public class MatchSummaryBoardData
		{
			public MatchResult MatchResult;

			public readonly MatchSummaryTeamStatsData BlueTeamStatsData;

			public readonly MatchSummaryTeamStatsData RedTeamStatsData;

			public readonly List<MatchSummaryPlayerData> PlayersData;
		}

		public class MatchSummaryTeamStatsData
		{
			public string Score;

			public string Possession;
		}

		public class MatchSummaryPlayerData
		{
			public bool IsRanked;

			public PlayerLastMatchStatistics Statistics;
		}

		[Serializable]
		public class BoardAnimationConfig
		{
			public float StartYPoint;

			public float EndYPoint;

			public float MatchPrepareAnimateOutDuration;

			public float AnimationDuration;
		}

		[SerializeField]
		[Header("Animation Config")]
		private BoardAnimationConfig _animationConfig;

		[SerializeField]
		private GameObject _container;

		[SerializeField]
		[Header("Data")]
		private MatchSummaryTeamBoard _blueTeamBoard;

		[SerializeField]
		private MatchSummaryTeamBoard _redTeamBoard;

		[SerializeField]
		private GameObject _colliderOnServer;

		[Header("Optimization")]
		[SerializeField]
		private LocalPlayerCheckVolume _blueTeamPlayerCheckVolume;

		[SerializeField]
		private Camera _blueTeamCamera;

		[SerializeField]
		private LocalPlayerCheckVolume _redTeamPlayerCheckVolume;

		[SerializeField]
		private Camera _redTeamCamera;

		private MatchSummaryBoardData _blueTeamBoardData;

		private MatchSummaryBoardData _redTeamBoardData;

		private IMessageSubscriber[] _subscribers;

		private Sequence _sequence;

		private bool _hasMatchResult;

		private bool _hasAllPlayersLastMatchStatistics;

		private bool _isShowing;

		public void TryHideBoard()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void KillSequence()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnBlueTeamBoardCheckVolumeChanged(bool hasPlayer)
		{
		}

		private void HandleOnRedTeamBoardCheckVolumeChanged(bool hasPlayer)
		{
		}

		private int HandleOnMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private void SetTeamMatchResult(MatchResult blueTeamResult, MatchResult redTeamResult)
		{
		}

		public void ToggleBoardColliderOnServer(bool enable)
		{
		}

		private void TryShowBoard()
		{
		}

		private void SetTeamStatsData(MatchSummaryBoardData teamBoardData)
		{
		}

		private int HandleOnPlayersLastMatchStatisticsUpdated(IMessage<PlayersLastMatchStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private void SetTeamBoardData(MatchSummaryBoardData boardData, string playFabId, PlayerLastMatchStatistics statistics)
		{
		}

		private string FormatNumber(float number)
		{
			return null;
		}
	}
}
