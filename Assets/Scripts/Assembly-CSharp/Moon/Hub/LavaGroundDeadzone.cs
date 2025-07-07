using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Hub
{
	public class LavaGroundDeadzone : MonoBehaviour
	{
		[SerializeField]
		private AnimationCurve _powerMultiple;

		[SerializeField]
		private int _maxLavaWalkCount;

		[SerializeField]
		private float _resetDelay;

		[SerializeField]
		private float _maxExpectedForce;

		[SerializeField]
		private float _gravityInfluence;

		[SerializeField]
		private float _minAdditionToJumpHeight;

		[SerializeField]
		private float _platformSearchRadius;

		private GameObject _currentPlayerBurnedFx;

		private Vector3 _horizontalDirection;

		private Vector3 _launchVelocity;

		private int _currentWalkCount;

		private bool _isExitLava;

		private Vector3 _targetPosition;

		private float _timer;

		private bool _isTimerStart;

		private float _distanceFromTargetPos;

		public event Action<Vector3> OnPlayerDidLavaJump
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private bool GetNearestPoint(out Vector3 position)
		{
			position = default(Vector3);
			return false;
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void HandleCollideWithDeadZone(int layerMask)
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void LavaJump(Vector3 targetPos)
		{
		}

		private void Update()
		{
		}

		private void LocalPlayerRig_OnHandColliding(Transform hand, bool isLeft, RaycastHit hit)
		{
		}
	}
}
