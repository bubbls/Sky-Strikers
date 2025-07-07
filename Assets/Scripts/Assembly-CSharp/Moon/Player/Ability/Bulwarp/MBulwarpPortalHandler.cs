using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Player.Ability.Bulwarp
{
	[NetworkBehaviourWeaved(0)]
	public class MBulwarpPortalHandler : MPortalHandler
	{
		[SerializeField]
		private float _minimumBallSpeed;

		[SerializeField]
		private float _minimumPlayerSpeed;

		[SerializeField]
		private float _playerSpeedMultiplier;

		private HittableHitInfo _cachedHitInfo;

		private static Changed<MBulwarpPortalHandler> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MBulwarpPortalHandler> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MBulwarpPortalHandler> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void HandleTeleport(GameObject go)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyAboutObjectTeleported(int layer, Vector3 teleportToPoint)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 7, 7)]
		[Preserve]
		protected unsafe static void Rpc_NotifyAboutObjectTeleported_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
