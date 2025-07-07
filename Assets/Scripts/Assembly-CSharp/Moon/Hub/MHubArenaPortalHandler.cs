using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(0)]
	public class MHubArenaPortalHandler : MPortalHandler
	{
		[SerializeField]
		private float _minimumBallSpeed;

		private HittableHitInfo _cachedHitInfo;

		private static Changed<MHubArenaPortalHandler> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaPortalHandler> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaPortalHandler> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void HandleTeleport(GameObject go)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true)]
		private void Rpc_NotifyAboutObjectTeleported(int layer)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 7, 1)]
		[Preserve]
		protected unsafe static void Rpc_NotifyAboutObjectTeleported_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
