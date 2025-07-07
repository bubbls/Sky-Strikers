using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Sound;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Interaction
{
	[RequireComponent(typeof(GrabbableHandFollower))]
	[NetworkBehaviourWeaved(3)]
	public class MGrabbableRotatingLever : MGrabbable, IDistanceRestrictedGrabbable
	{
		private const float MaxRotation = 180f;

		[DefaultForProperty("NetworkedTotalRotation", 1, 1)]
		[SerializeField]
		private float _NetworkedTotalRotation;

		[DefaultForProperty("NetworkedMoveToRotation", 2, 1)]
		[SerializeField]
		private float _NetworkedMoveToRotation;

		[Header("Config")]
		[Space(7f)]
		[SerializeField]
		private float _grabbedFollowSpeed;

		[SerializeField]
		private Transform _offsetTransform;

		[SerializeField]
		private Transform _rotatePoint;

		[SerializeField]
		private GrabbableHandFollower _handFollower;

		[SerializeField]
		private Transform _distanceCheckPoint;

		[SerializeField]
		private bool _isAntiClockwise;

		[SerializeField]
		private float _rotateToTargetSpeed;

		[SerializeField]
		private float _maxRotationChangeAllowed;

		[SerializeField]
		private float _smoothTime;

		[SerializeField]
		private float _minDistanceForFeedback;

		[SerializeField]
		private float _grabDistance;

		private float _currentTotalRotation;

		[Header("Haptic")]
		[Space(7f)]
		[SerializeField]
		private float _hapticDuration;

		[SerializeField]
		private float _hapticAmp;

		[SerializeField]
		[Space(7f)]
		[Header("Sfx")]
		private SoundInfo _moveSound;

		[SerializeField]
		private SoundInfo _grabRejectedSfx;

		private int _moveSoundId;

		private int _grabRejectedSfxId;

		private float _hapticAmpMultiplier;

		private float _rotationVelocity;

		private float _targetTotalRotation;

		private float _lastGrabbedAngle;

		private Vector3 _cachedMoveDirection;

		private float _cachedMoveAngle;

		private float _previousTargetTotalRotation;

		private bool _grabbedOnCurrentClient;

		private bool _isSpawned;

		private int _cachedNearestMoveToRotation;

		private float _distanceFromNearestMoveToRotation;

		private Quaternion _targetRotation;

		private Quaternion _currentRotation;

		private static Changed<MGrabbableRotatingLever> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGrabbableRotatingLever> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGrabbableRotatingLever> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(1, 1)]
		public float NetworkedTotalRotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(2, 1)]
		public float NetworkedMoveToRotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MaxGrabDistance => 0f;

		public Vector3 DistanceCheckPointPosition => default(Vector3);

		public float Value { get; private set; }

		public bool IsRotating => false;

		public float CurrentRotationAngle => 0f;

		public event Action<float> OnValueChanged
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

		public event Action OnSpawned
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

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		[Rpc]
		private void RPC_UpdateTotalRotation(float updatedTotalRotation)
		{
		}

		public void SetReleasedTargetRotation(int minRotationAmount, int minDistanceToNearestMoveTo)
		{
		}

		public void SetHapticAmpMultiplier(float multiplier)
		{
		}

		public void ForceSetRotation(float rotationAngle)
		{
		}

		private void LateUpdate()
		{
		}

		protected override void HandleOnGrabbedInternal()
		{
		}

		protected override void HandleOnReleaseInternal()
		{
		}

		private void CalculateAngles(float angle, in float lastAngle, out float rotationChange)
		{
			rotationChange = default(float);
		}

		private void UpdateValue()
		{
		}

		private void TryPlayMoveSound()
		{
		}

		public override void PlayGrabRejected(MGrabInteractor interactor)
		{
		}

		private static int FindNearestMultiple(int number, int multiple)
		{
			return 0;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 7, 7)]
		[Preserve]
		protected unsafe static void RPC_UpdateTotalRotation_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
