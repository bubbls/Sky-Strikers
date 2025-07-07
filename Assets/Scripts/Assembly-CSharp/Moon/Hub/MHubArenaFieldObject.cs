using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Server | SimulationModes.Host))]
	[NetworkBehaviourWeaved(2)]
	public abstract class MHubArenaFieldObject : NetworkBehaviour
	{
		[DefaultForProperty("IsFinishedAnimating", 0, 1)]
		[SerializeField]
		private NetworkBool _IsFinishedAnimating;

		[SerializeField]
		[DefaultForProperty("ShouldShow", 1, 1)]
		private NetworkBool _ShouldShow;

		[SerializeField]
		private GameObjectLODListener[] _lodListeners;

		private static Changed<MHubArenaFieldObject> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaFieldObject> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaFieldObject> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 1)]
		public NetworkBool IsFinishedAnimating
		{
			get
			{
				return default(NetworkBool);
			}
			protected set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(1, 1)]
		public NetworkBool ShouldShow
		{
			get
			{
				return default(NetworkBool);
			}
			private set
			{
			}
		}

		public GameObjectLODListener[] LODListeners => null;

		protected abstract void AnimateIn(float duration);

		protected abstract void AnimateOut(float duration);

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, Channel = RpcChannel.Reliable)]
		public void Rpc_NotifyAnimateOut(float animateOutDuration)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, Channel = RpcChannel.Reliable)]
		public void Rpc_NotifyAnimateIn(float animateInDuration)
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
		protected unsafe static void Rpc_NotifyAnimateOut_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 1, 7)]
		protected unsafe static void Rpc_NotifyAnimateIn_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
