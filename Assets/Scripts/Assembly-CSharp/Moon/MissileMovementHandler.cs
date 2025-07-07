using System.Collections.Generic;
using Fusion;
using UnityEngine;

namespace Moon
{
	public class MissileMovementHandler
	{
		private Transform _transform;

		private MissileConfig _missileConfig;

		private MissileLifetimeData _lifetimeData;

		private Vector3 _nextPosition;

		private Quaternion _nextRotation;

		private RaycastHit[] _raycastHits;

		private List<LagCompensatedHit> _hits;

		private List<LagCompensatedHit> _orderedHits;

		private Vector3 _missileExtents;

		private Vector3 _missileCenter;

		private Vector3 _startPos;

		private Vector3 _endPos;

		private float _hitProbe;

		private bool _hitResult;

		private int _overlapCount;

		private int _hitCount;

		private float _cachedTime;

		private Vector3 _cachedForward;

		public Vector3 CurrentPosition { get; private set; }

		public void Configure(Transform transform, MissileConfig missileConfig, MissileLifetimeData lifetimeData)
		{
		}

		public bool ProbingHit(Tick currentTick, out Vector3 hitPos, out Vector3 hitUpDir)
		{
			hitPos = default(Vector3);
			hitUpDir = default(Vector3);
			return false;
		}

		private bool DetectHit(Tick tickStart, Tick tickEnd, out Vector3 hitPos, out Vector3 hitUpDir)
		{
			hitPos = default(Vector3);
			hitUpDir = default(Vector3);
			return false;
		}

		private Vector3 GetMovePosition(float currentTick)
		{
			return default(Vector3);
		}

		private bool IsPassedExplosionTick()
		{
			return false;
		}

		public void MoveToNextPosition()
		{
		}
	}
}
