using Fusion;
using Moon.Interaction;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub.Instrument
{
	[NetworkBehaviourWeaved(2)]
	public class MGrabbableHarpHandle : MGrabbable
	{
		[SerializeField]
		[Header("Harp")]
		private MHarp _mHarp;

		[Header("Config")]
		[SerializeField]
		private Transform _handleOut;

		[SerializeField]
		private Transform _handleIn;

		[SerializeField]
		private float _handleMoveSpeed;

		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private float _handleXOffset;

		[SerializeField]
		private float _distanceLimit;

		[Header("Path")]
		[SerializeField]
		private Transform _startPoint;

		[SerializeField]
		private Transform _controlPoint1;

		[SerializeField]
		private Transform _controlPoint2;

		[SerializeField]
		private Transform _endPoint;

		[DefaultForProperty("PitchValue", 1, 1)]
		private float _PitchValue;

		private static Changed<MGrabbableHarpHandle> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGrabbableHarpHandle> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGrabbableHarpHandle> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(1, 1)]
		[Networked(OnChanged = "HandleOnPitchValueChanged")]
		private float PitchValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void Spawned()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		public override void Render()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void Rpc_UpdatePitchValue(float pitchValue)
		{
		}

		[Preserve]
		private static void HandleOnPitchValueChanged(Changed<MGrabbableHarpHandle> changed)
		{
		}

		private void UpdatePitchValue()
		{
		}

		protected override void HandleOnGrabbedInternal()
		{
		}

		protected override void HandleOnReleaseInternal()
		{
		}

		private void DrawLine()
		{
		}

		private float GetMovePercentage(float yPosition)
		{
			return 0f;
		}

		private float GetRemappedPitchValue(float yPosition)
		{
			return 0f;
		}

		private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default(Vector3);
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 7, 1)]
		[Preserve]
		protected unsafe static void Rpc_UpdatePitchValue_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
