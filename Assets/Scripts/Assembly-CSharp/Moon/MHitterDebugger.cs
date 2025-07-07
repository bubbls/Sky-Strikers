using System.Collections.Generic;
using Fusion;
using Moon.AI.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon
{
	[NetworkBehaviourWeaved(0)]
	public class MHitterDebugger : NetworkBehaviour
	{
		[SerializeField]
		private Hitbox _debugHitbox;

		[SerializeField]
		private GameObject _debugBatWireframe;

		[SerializeField]
		private GameObject _debugBallWireframe;

		private List<Transform> _debugBallVisuals;

		private List<Transform> _debugBatVisuals;

		private int _debugBallCount;

		private int _debugBatCount;

		private TickTimer _debugTimer;

		private HashSet<Hitbox> _hitBoxes;

		private List<int> _ticks;

		private List<Vector3> _tickBallPositions;

		private List<Quaternion> _tickBallRotations;

		private List<Vector3> _tickBatPositions;

		private List<Quaternion> _tickBatRotations;

		private OverlapShapeDesc _overlapShapeDesc;

		private static Changed<MHitterDebugger> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHitterDebugger> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHitterDebugger> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		private void ResetList()
		{
		}

		private void DebugBatAndBall(Hitbox hitBox, int tick)
		{
		}

		public void DebugHitWithLagCompensationOnClient(HitSourceID sourceID, OverlapShapeDesc overlapShapeDesc, int layerMask)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority)]
		private void RPC_RequestPositionAndRotationOnTick(int[] ticks)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.InputAuthority)]
		private void RPC_SyncPositionAndRotationOnTick(int[] ticks, Vector3[] ballPositions, Quaternion[] ballRotations, Vector3[] batPositions, Quaternion[] batRotations)
		{
		}

		private void ResetDebugBatAndBall()
		{
		}

		private void DebugBatVisual(Vector3 position, Quaternion rotation, OverlapShapeDesc overlapShapeDesc)
		{
		}

		private void DebugBallVisual(Vector3 position, Quaternion rotation)
		{
		}

		private void SetPositionAndRotation(Transform target, Vector3 position, Quaternion rotation, Vector3 offset, Vector3 boxExtents)
		{
		}

		private void SetPositionAndRotation(Transform target, Vector3 position, Quaternion rotation, Vector3 offset, float sphereRadius)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 2, 1)]
		protected unsafe static void RPC_RequestPositionAndRotationOnTick_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 1, 2)]
		protected unsafe static void RPC_SyncPositionAndRotationOnTick_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
