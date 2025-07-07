using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DP.Takeaway.Runtime;
using Moon.Arena;
using Moon.InputSystem;
using Moon.Player;
using UnityEngine;

namespace Moon
{
	[RequireComponent(typeof(Rigidbody))]
	[DefaultExecutionOrder(-1)]
	public class PlayerLocomotion : MonoBehaviour
	{
		[Serializable]
		private class SnapTurnAngles : SerializableDictionary<GameOption.SnapTurnAngle, float>
		{
		}

		[Serializable]
		private class SmoothTurnSpeed : SerializableDictionary<GameOption.SmoothTurnSpeed, float>
		{
		}

		private static int _velocityHistorySize;

		private static bool _requestCreateVelocityHistory;

		[SerializeField]
		private Transform _leftHandTransform;

		[SerializeField]
		private Transform _rightHandTransform;

		[SerializeField]
		private SphereCollider _headCollider;

		[SerializeField]
		private Collider _bodyCollider;

		[SerializeField]
		private Transform _bodyColiderPivot;

		[SerializeField]
		private float _defaultSlideFactor;

		[SerializeField]
		private float _minimumRaycastDistance;

		[SerializeField]
		public float _defaultPrecision;

		[SerializeField]
		private float _maxArmLength;

		[SerializeField]
		private float _unStickDistance;

		[SerializeField]
		private Transform _trackerOffset;

		[SerializeField]
		private Transform _trackerPivot;

		[SerializeField]
		private float _snapTurnPushAmount;

		[SerializeField]
		private float _creationModeMoveSpeed;

		[SerializeField]
		private float _creationModeAcceleration;

		[SerializeField]
		private SnapTurnAngles _snapTurnAngles;

		[SerializeField]
		private SmoothTurnSpeed _smoothTurnSpeeds;

		[Header("Overwritten by default locomotion configuration")]
		[Space(7f)]
		[SerializeField]
		private PlayerLocomotionConfiguration _locomotionConfiguration;

		private Rigidbody _playerRigidBody;

		private Transform _leftHandFollower;

		private RaycastHit _cachedInnerHit;

		private readonly Dictionary<string, float> _movementDisableSources;

		private readonly List<string> _movementDisabledSourcesToRemove;

		private PlayerLocomotionPlugin _plugin;

		private bool _physicalMovementEnabled;

		private Transform _rightHandFollower;

		private bool _disableMovement;

		private Vector3 _lastLeftHandPosition;

		private Vector3 _lastRightHandPosition;

		private Vector3 _lastHeadPosition;

		private bool _wasLeftHandTouching;

		private bool _wasRightHandTouching;

		private int _velocityIndex;

		private Vector3[] _velocityHistory;

		private Vector3 _currentVelocity;

		private Vector3 _denormalizedVelocityAverage;

		private Vector3 _lastPosition;

		private Vector3 _targetPlayerVelocity;

		private Vector3 _rightHandVelocity;

		private Vector3 _leftHandVelocity;

		private Vector3 _handsVelocity;

		private Vector3 _targetBodyRotation;

		private float _handsVelocityMagnitude;

		private float _surfaceBounceFactor;

		private float _cachedDeltaTime;

		private PlayerInput.Mode _playerInputMode;

		private bool _moveFaster;

		public static int VelocityHistorySize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public SphereCollider HeadCollider => null;

		public Transform TrackerPivot => null;

		public Rigidbody PlayerRigidBody => null;

		private Transform LeftHandFollower => null;

		private Transform RightHandFollower => null;

		public event Action<Transform, bool, RaycastHit> OnHandColliding
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

		private void Awake()
		{
		}

		public void SetConfiguration(PlayerLocomotionConfiguration configuration)
		{
		}

		public void ChangeInputMode(PlayerInput.Mode inputMode)
		{
		}

		private void CreateVelocityHistoryBuffer()
		{
		}

		private void OnDestroy()
		{
		}

		private void InitializeValues()
		{
		}

		public void SetLocomotionPlugin(PlayerLocomotionPlugin plugin)
		{
		}

		public void MoveOnEyeSightPlane(Vector3 axis)
		{
		}

		public void SetMoveFaster(bool moveFaster)
		{
		}

		public void HandleXrInput(MXRInputData mxrInputData)
		{
		}

		public bool TryTurn(MXRInputData mxrInputData)
		{
			return false;
		}

		private bool SmoothTurn(float xInput)
		{
			return false;
		}

		private bool TrySnapTurn(MXRInputAction xInput)
		{
			return false;
		}

		private void DoSnapTurn(float turnAngle)
		{
		}

		public void DisableMovement(string source, float duration = 0f)
		{
		}

		public void EnableMovementAndReinitializeValues(params string[] sources)
		{
		}

		private bool TryEnableMovement()
		{
			return false;
		}

		private void Update()
		{
		}

		public void ResetLocomotion()
		{
		}

		public void LookForward()
		{
		}

		public void SyncBodyHead(bool force = false)
		{
		}

		private Vector3 CurrentHeadPosition()
		{
			return default(Vector3);
		}

		private Vector3 CurrentLeftHandPosition()
		{
			return default(Vector3);
		}

		private Vector3 CurrentRightHandPosition()
		{
			return default(Vector3);
		}

		private Vector3 PositionWithOffset(Transform t, Vector3 offset)
		{
			return default(Vector3);
		}

		private Quaternion CurrentLeftHandRotation()
		{
			return default(Quaternion);
		}

		private Quaternion CurrentRightHandRotation()
		{
			return default(Quaternion);
		}

		private void UpdateMovement(float deltaTime)
		{
		}

		private bool IterativeCollisionSphereCast(Vector3 startPosition, float sphereRadius, Vector3 movementVector, float precision, out Vector3 endPosition, bool singleHand, out RaycastHit hitInfo)
		{
			endPosition = default(Vector3);
			hitInfo = default(RaycastHit);
			return false;
		}

		private bool CollisionsSphereCast(Vector3 startPosition, float sphereRadius, Vector3 movementVector, float precision, out Vector3 finalPosition, out RaycastHit hitInfo)
		{
			finalPosition = default(Vector3);
			hitInfo = default(RaycastHit);
			return false;
		}

		private void StoreVelocities(float deltaTime, Vector3 position)
		{
		}

		private void ValidateVelocityHistoryBuffer()
		{
		}

		private void ApplyMovementVelocityToPlayer(bool hasHandColliding)
		{
		}
	}
}
