using System;
using System.Collections.Generic;
using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Interaction
{
	[NetworkBehaviourWeaved(5)]
	public class MGrabbablePath : MGrabbable
	{
		[Serializable]
		private class PathSegment
		{
			public int SegmentSmoothness;

			public Transform[] ControlPoints;

			public Transform EndPoint;
		}

		[DefaultForProperty("NetworkedCurrentPointIndex", 1, 1)]
		private int _NetworkedCurrentPointIndex;

		[DefaultForProperty("NetworkedHandlePosition", 2, 3)]
		private Vector3 _NetworkedHandlePosition;

		[SerializeField]
		private SlidingCurve _curve;

		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private Transform _pathStartPoint;

		[SerializeField]
		private PathSegment[] _pathSegments;

		[SerializeField]
		private Transform _handle;

		[SerializeField]
		private float _moveUpSpeed;

		[SerializeField]
		private float _moveBackSpeed;

		[SerializeField]
		private float _playerReleaseVelocityBoost;

		[SerializeField]
		private float _minPlayerHeightOffset;

		[SerializeField]
		[Space(7f)]
		[Header("Haptic")]
		private float _hapticDuration;

		[SerializeField]
		private float _hapticAmp;

		[Space(7f)]
		[Header("Sfx")]
		[SerializeField]
		private SoundInfo _movingSound;

		[SerializeField]
		private SoundInfo _moveDoneSound;

		private MPlayer _mLocalPlayer;

		private LocalPlayerRig _localPlayerRig;

		private GrabbablePathVelocityTracker _velocityTracker;

		private Vector3 _playerOffset;

		private int _currentPointIndex;

		private Vector3 _currentHandlePosition;

		public Vector3 _nextPathPosition;

		private int _movingSoundID;

		private bool _grabbedOnCurrentClient;

		private Vector3 _cachedBezierPoint;

		private float _cachedT;

		private int _cachedLastPointIndex;

		private Vector3 _cachedPathStartPoint;

		private static Changed<MGrabbablePath> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGrabbablePath> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGrabbablePath> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(1, 1)]
		[Networked]
		private int NetworkedCurrentPointIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(2, 3)]
		private Vector3 NetworkedHandlePosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public override void Spawned()
		{
		}

		private void FillLineRendererFromSlidingCurve()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		[Rpc]
		private void RPC_UpdateGrabbedHandlePosition(Vector3 position, int pointIndex)
		{
		}

		public override void Render()
		{
		}

		protected override void HandleOnGrabbedInternal()
		{
		}

		protected override void HandleOnReleaseInternal()
		{
		}

		private Vector3 GetBezierPoint(float t, List<Vector3> controlPoints)
		{
			return default(Vector3);
		}

		private bool ReachedEndOfPath(int index)
		{
			return false;
		}

		private void CreateCurvePath()
		{
		}

		private void OnDrawGizmos()
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
		protected unsafe static void RPC_UpdateGrabbedHandlePosition_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
