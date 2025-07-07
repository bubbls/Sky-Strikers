using System;
using Chamber8.Framework.Messaging;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[OrderAfter(new Type[] { typeof(MArenaGameManagerHandler) })]
	[NetworkBehaviourWeaved(1)]
	[RequireComponent(typeof(MFSM))]
	public class MGameManager : NetworkBehaviour
	{
		private const string TeamOneGroupName = "TeamOneSpawnPoints";

		private const string TeamTwoGroupName = "TeamTwoSpawnPoints";

		private const string ArenaDoorRestrictedArea = "ArenaDoorRestrictedArea";

		[DefaultForProperty("IsMatchInProgress", 0, 1)]
		[SerializeField]
		private NetworkBool _IsMatchInProgress;

		private int _teleportPointIndexOne;

		private int _teleportPointIndexTwo;

		private IMessageSubscriber _fieldMessageSubscriber;

		private static Changed<MGameManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGameManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGameManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 1)]
		public NetworkBool IsMatchInProgress
		{
			get
			{
				return default(NetworkBool);
			}
			protected set
			{
			}
		}

		public bool IsActive { get; private set; }

		public void HandleOnSpawned()
		{
		}

		protected virtual void SetInitialStateAfterSpawned()
		{
		}

		public virtual void HandleFixedUpdateNetwork()
		{
		}

		public void HandleOnDespawned()
		{
		}

		protected virtual void HandleDespawnInternal()
		{
		}

		protected void DisablePowerUps()
		{
		}

		protected void ResetPowerUps()
		{
		}

		protected void SetAmmo(int count)
		{
		}

		protected void IncrAmmo(int count)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void RPC_RepositionPlayer([RpcTarget] PlayerRef playerRef, Vector3 position, Quaternion rotation)
		{
		}

		public static bool IsPlayerAtTeleportableLocation(PlayerRef playerRef)
		{
			return false;
		}

		[ContextMenu("Moon/Reposition Players")]
		protected void RepositionPlayers()
		{
		}

		private void RepositionPlayer(PlayerRef playerRef)
		{
		}

		private void ResetTeleportPointIndexes()
		{
		}

		private Transform GetTeleportPoint(TeamNo teamNo)
		{
			return null;
		}

		private int HandlePlayerAction(IMessage<PlayerActionMessage> message)
		{
			return 0;
		}

		protected string GetScenePath()
		{
			return null;
		}

		protected void ToggleArenaDoorBulwarpRestrictionArea(bool enable)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 1, 7)]
		[Preserve]
		protected unsafe static void RPC_RepositionPlayer_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
