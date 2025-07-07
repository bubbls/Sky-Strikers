using System;
using System.Collections.Generic;
using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using UnityEngine;

namespace Moon.Interaction
{
	public class LocalGrabbablePath : LocalGrabbable
	{
		[Serializable]
		private class PathSegment
		{
			public int SegmentSmoothness;

			public Transform[] ControlPoints;

			public Transform EndPoint;
		}

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

		[Header("Sfx")]
		[SerializeField]
		[Space(7f)]
		private SoundInfo _movingSound;

		[SerializeField]
		private SoundInfo _moveDoneSound;

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

		protected override void Start()
		{
		}

		private void FillLineRendererFromSlidingCurve()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		private void RPC_UpdateGrabbedHandlePosition(int pointIndex)
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
	}
}
