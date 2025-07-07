using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Arena;
using Moon.Bootstrap;
using Moon.Framework.Leaderboard;
using Moon.Leaderboard;
using Moon.MultiPlay;
using Moon.PlayerProfile;
using UnityEngine;

namespace Moon
{
	public class PlayerMatchStatsHandler : PlayerStatsHandler
	{
		public class PlayerRatingData
		{
			public TeamNo PlayerTeamNo;

			public int Rating;
		}

		private const int BuzzardBeaterMinSecondsBeforeMatchEnd = 5;

		private const int ClearHitDistance = 12;

		private const int ClearHitThresholdDuration = 5;

		private const float MinTimeBetweenSaves = 1f;

		private PlayerMatchStats _currentMatchStats;

		private PlayerGoalStats _currentGoalStats;

		private bool _isInTeamGoalArea;

		private Location _teamGoalLocation;

		private TickTimer _lastSaveTimer;

		private MPlayer _player;

		private float _clearHitTimer;

		private float _lastPlayerHitTime;

		private Vector3 _lastPlayerPosition;

		private Vector3 _goalDirection;

		private AnimationCurve _shotDefinitionCurve;

		private bool _isMvp;

		private int _rating;

		private bool _isInTargetShotArea;

		private IMessageSubscriber _subscriber;

		private float _onGroundTimer;

		private float _lowAirTimer;

		private float _highAirTimer;

		private float _totalOnGroundTime;

		private float _totalLowAirTime;

		private float _totalHighAirTime;

		private bool _canTrackArenaStats;

		private float _inMiddleThirdTimer;

		private float _inDefensiveThirdTimer;

		private float _inOffensiveThirdTimer;

		private float _totalInMiddleThirdTime;

		private float _totalInDefensiveThirdTime;

		private float _totalInOffensiveThirdTime;

		private List<PlayerTimeOnGroundStat> _onGroundStats;

		private List<PlayerPositionStat> _positionStats;

		private Transform _teamOneArenaGoalLine;

		private Transform _teamTwoArenaGoalLine;

		private ArenaTeamArea _teamOneArea;

		private ArenaTeamArea _teamTwoArea;

		private bool _canValidateClear;

		private bool _alreadyAddedShot;

		private readonly Dictionary<string, int> _playerLeftTimer;

		public TeamNo TeamNo => default(TeamNo);

		public PlayerMatchStatsHandler(PlayerRef playerRef, string playFabId, PlayerInfo playerInfo)
			: base(default(PlayerRef), null, default(PlayerInfo))
		{
		}

		public int GetPlayerPossessionTime()
		{
			return 0;
		}

		public void SetShotDefinitionCurve(AnimationCurve shotCurve)
		{
		}

		public void SetArenaGoal(Transform teamOneArenaGoalLine, Transform teamTwoArenaGoalLine)
		{
		}

		public void SetPlayerOnGroundAreas(List<PlayerTimeOnGroundStat> onGroundStats, List<PlayerPositionStat> positionStats)
		{
		}

		public void SetTeamAreas(ArenaTeamArea teamOneArea, ArenaTeamArea teamTwoArea)
		{
		}

		private void TeamArea_OnBallEnter(TeamNo teamNo, MBall mBall)
		{
		}

		public override void StartTracking()
		{
		}

		private void ResetOnAreaStatsTime()
		{
		}

		public override void StopTracking()
		{
		}

		public override void HandleRocketFired(GeneralActionMessageData messageData)
		{
		}

		public override void HandleLocalPlayerLocationChanged(PlayerLocationChangedMessage playerLocationChangedMessage)
		{
		}

		public override void HandlePlayerEnergyCollected(PlayerEnergyCollectedMessage playerEnergyCollectedMessage)
		{
		}

		public override void OnMatchStarted()
		{
		}

		public override void OnMatchPrepare()
		{
		}

		private void CheckClearHit(MPlayer mPlayer)
		{
		}

		public void HandleBallHit(NetworkRunner runner, BallHittableInfoMessageData ballHitMessageData)
		{
		}

		private void CalculatePossession()
		{
		}

		private int HandleOnPlayerDoTargetShot(IMessage<PlayerDoTargetShotMessage> message)
		{
			return 0;
		}

		public override void OnMatchCelebrateGoal(GoalMessageData goalMessageData)
		{
		}

		public void HandleOnMatchCompleted(int realTotalPlayTime, int totalPlayTime, int totalPossessionTime, MatchEndMessageData matchEndMessageData)
		{
		}

		public void CalculateIsMvp(Dictionary<string, PlayerRatingData> allPlayersRating)
		{
		}

		public bool IsTotalPlayTimeValid()
		{
			return false;
		}

		public List<Statistic> OperateStatsListOnMatchCompleted(string playFabId, bool isForfeit)
		{
			return null;
		}

		public void NotifyLastMatchStatsUpdate()
		{
		}

		private void NotifyLastMatchStatsUpdate(int mmr, int newMMR, bool isUnderdog, int underdogMMR, int winStreakMMR, bool isForfeit)
		{
		}

		private bool CheckIsUnderdog()
		{
			return false;
		}

		public void NotifyStatsUpdatedOnMatchCompleted()
		{
		}

		public override void HandlePlayerAmmoStatusChanged(WeaponType weaponType, MAmmoBox.Status status)
		{
		}

		private void UpdatePlayerTimeOnGroundStat()
		{
		}

		private void CalculatePlayerOnGroundTime(PlayerOnGroundType groundType)
		{
		}

		private void UpdatePlayerPositionStat()
		{
		}

		private void CalculatePlayerPositionStatsTime(TeamNo teamNo)
		{
		}

		public override void HandleFixedNetworkUpdate()
		{
		}

		public void HandleOnPlayerJoined(PlayerAddedMessage payload)
		{
		}

		public void HandleOnPlayerLeft(PlayerRemovedMessage payload, int currentPlayTime)
		{
		}

		private void CheckForBuzzardBeater()
		{
		}

		private void InitGoalDirection()
		{
		}

		private void CheckIfTopScorer()
		{
		}

		private void ResetTickTimers()
		{
		}

		private PlayerLastMatchStatistics GenerateLastMatchStats(int mmr, int newMMR, bool isPlayerForfeit, bool isUnderdog, int underdogMMR, int winStreakMMR)
		{
			return default(PlayerLastMatchStatistics);
		}

		public int GetRating()
		{
			return 0;
		}
	}
}
