using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(0)]
	public class MTutorialHandler : MPortalHandler
	{
		[SerializeField]
		private float _minBallSpeed;

		[SerializeField]
		private float _MaxBallSpeed;

		[SerializeField]
		private bool _keepBallSpeed;

		private HittableHitInfo _cachedHitInfo;

		private static Changed<MTutorialHandler> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MTutorialHandler> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MTutorialHandler> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

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

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 7, 1)]
		protected unsafe static void Rpc_NotifyAboutObjectTeleported_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
