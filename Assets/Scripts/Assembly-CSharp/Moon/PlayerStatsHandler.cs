using Fusion;
using Moon.Arena;
using Moon.MultiPlay;

namespace Moon
{
	public abstract class PlayerStatsHandler
	{
		protected const float DelayExitStatsTrackingAreaTime = 10f;

		public PlayerRef ThisPlayer { get; protected set; }

		public PlayerInfo ThisPlayerInfo { get; protected set; }

		public string PlayFabId { get; private set; }

		public PlayerStatsHandler(PlayerRef playerRef, string playFabId, PlayerInfo playerInfo)
		{
		}

		public virtual void StartTracking()
		{
		}

		public virtual void StopTracking()
		{
		}

		public virtual void HandleLocalPlayerLocationChanged(PlayerLocationChangedMessage playerLocationChangedMessage)
		{
		}

		public virtual void HandlePlayerEnergyCollected(PlayerEnergyCollectedMessage playerEnergyCollectedMessage)
		{
		}

		public virtual void HandlePlayerAbilityInflicted(PlayerAbilityMessageData playerAbilityMessageData)
		{
		}

		public virtual void HandlePlayerPossessionChanged(TeamNo teamNo)
		{
		}

		public virtual void HandlePlayerAmmoStatusChanged(WeaponType weaponType, MAmmoBox.Status status)
		{
		}

		public virtual void HandleRocketFired(GeneralActionMessageData generalActionMessageData)
		{
		}

		public virtual void HandleBallHit(BallHittableInfoMessageData ballHittableInfoMessageData)
		{
		}

		public virtual void OnEnterStatsTrackingArea()
		{
		}

		public virtual void OnExitStatsTrackingArea()
		{
		}

		public virtual void OnMatchPrepare()
		{
		}

		public virtual void OnMatchStarted()
		{
		}

		public virtual void OnMatchCelebrateGoal(GoalMessageData goalMessageData)
		{
		}

		public virtual void OnMatchCompleted(MatchEndMessageData matchEndMessageData)
		{
		}

		public virtual void HandleFixedNetworkUpdate()
		{
		}

		public void UpdatePlayerInfo(PlayerRef playerRef, PlayerInfo playerInfo)
		{
		}

		public void UnbindPlayerRef()
		{
		}

		protected string ConvertStatNameToRankedNoClass(string targetName)
		{
			return null;
		}

		protected string ConvertStatNameToRanked(string targetName)
		{
			return null;
		}

		protected string ConvertStatNameToTotal(string targetName)
		{
			return null;
		}
	}
}
