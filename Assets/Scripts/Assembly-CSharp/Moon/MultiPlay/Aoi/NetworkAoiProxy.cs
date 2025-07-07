using System;
using Chamber8.Framework.Messaging;
using Fusion;
using UnityEngine;

namespace Moon.MultiPlay.Aoi
{
	[SimulationBehaviour(Stages = SimulationStages.Forward)]
	[DisallowMultipleComponent]
	[OrderAfter(new Type[] { typeof(MPlayer) })]
	[NetworkBehaviourWeaved(1)]
	public sealed class NetworkAoiProxy : NetworkBehaviour
	{
		public Action<bool> OnStateUpdated;

		private bool _isCulled;

		[DefaultForProperty("KeepAlive", 0, 1)]
		private NetworkBool _KeepAlive;

		private int _tickRate;

		private PlayerRef _ownerPlayerRef;

		private IMessageSubscriber _messageSubscriber;

		private bool _cachedIsCulled;

		private static Changed<NetworkAoiProxy> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<NetworkAoiProxy> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<NetworkAoiProxy> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public bool IsCulled => false;

		[Networked]
		[NetworkedWeaved(0, 1)]
		private NetworkBool KeepAlive
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		[ContextMenu("Print Tick Info")]
		private void LogTickInfo()
		{
		}

		private void OnPlayerJoined(PlayerRef playerRef)
		{
		}

		private void OnPlayerLeft(PlayerRef playerRef)
		{
		}

		private void OnPlayerInfoAboutToRefresh(PlayerRef playerRef, PlayerInfo oldPlayerInfo, PlayerInfo newPlayerInfo)
		{
		}

		private void OnPlayerInfoRefreshed(PlayerRef playerRef)
		{
		}

		private int HandleMPlayerContainerSpawnedMessage(IMessage<MPlayerContainer> message)
		{
			return 0;
		}

		private void RefreshOwnerPlayerInterest()
		{
		}

		private void HandlePlayerInterest(PlayerRef playerRef)
		{
		}

		private void HandlePlayerInterest(PlayerRef playerRef, PlayerInfo playerInfo, PlayerInfo ownerPlayerInfo, MPlayerContainer ownerContainer)
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
