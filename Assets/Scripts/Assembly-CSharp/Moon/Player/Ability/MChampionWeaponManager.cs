using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Fusion;
using JetBrains.Annotations;
using Moon.Bootstrap;
using Moon.Leaderboard;
using Moon.MultiPlay;
using UnityEngine.Scripting;

namespace Moon.Player.Ability
{
	[NetworkBehaviourWeaved(122)]
	public class MChampionWeaponManager : NetworkBehaviour
	{
		[DefaultForProperty("WeaponStatus", 0, 122)]
		[UsedImplicitly]
		private SerializableDictionary<PlayerRef, ChampionWeaponStatus> _WeaponStatus;

		private readonly ChampionWeaponStatusUpdatedMessage _cachedStatusUpdatedMessage;

		private IMessageSubscriber[] _messageSubscribers;

		private ChampionWeaponGoalTracker _goalTracker;

		private bool _canPreserveChampionWeaponStatus;

		private static Changed<MChampionWeaponManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MChampionWeaponManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MChampionWeaponManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Capacity(10)]
		[NetworkedWeaved(0, 122)]
		[Networked(OnChanged = "OnWeaponStatusChanged")]
		[UsedImplicitly]
		private NetworkDictionary<PlayerRef, ChampionWeaponStatus> WeaponStatus => default(NetworkDictionary<PlayerRef, ChampionWeaponStatus>);

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private int HandleOnPlayerInfoUpdated(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private void TrySetupPlayerChampionWeapon(PlayerRef playerRef, PlayerInfo playerInfo)
		{
		}

		private void SetupWeaponStatus(PlayerRef playerRef)
		{
		}

		private void RemoveChampionWeaponTrackingFromPlayer(PlayerRef playerRef)
		{
		}

		private int HandlePlayerStatsUpdated(IMessage<PlayerStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerRankedStatsUpdated(IMessage<PlayerRankedStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private int HandleChampionWeaponStatusRequested(IMessage<ChampionWeaponStatusRequestedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerAdded(IMessage<PlayerAddedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerRemoved(IMessage<PlayerRemovedMessage> message)
		{
			return 0;
		}

		[Preserve]
		private static void OnWeaponStatusChanged(Changed<MChampionWeaponManager> changed)
		{
		}

		private void RefreshChampionWeapons()
		{
		}

		private void NotifyWeaponStatusChanged(PlayerRef playerRef, ChampionWeaponStatus status)
		{
		}

		private void ToggleWeaponFxForPlayer(PlayerRef playerRef, bool isWeaponFxActive)
		{
		}

		private void GoalTracker_OnRankedMatchPlayersConfirmed()
		{
		}

		private void GoalTracker_RequestPreviewWeaponFxForPlayer(PlayerRef player)
		{
		}

		private void GoalTracker_RequestClearWeaponFxFromPlayers(List<PlayerRef> players)
		{
		}

		private void GoalTracker_RequestClearTopScorerFromPlayer(PlayerRef player)
		{
		}

		private void GoalTracker_OnPlayerRankedMatchGoalsChanged(PlayerRef player, byte matchGoals)
		{
		}

		private void GoalTracker_OnUpdateTopScorer(PlayerRef topScorer, PlayerRef previousTopScorer)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
