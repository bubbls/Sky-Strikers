using System;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using Moon.Arena;
using Moon.CreativeMode;
using Moon.InputSystem;
using Moon.Player;
using Moon.Portal;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Moon
{
	public class LocalPlayerRig : SingleMonoBehaviour<LocalPlayerRig, LocalPlayerRigSettings>, ICommandExecutor, ITrackerPositionRotationProvider, ITeleportable
	{
		private const float AutoTriggerDeadzoneYPos = -3000f;

		private const float DelayBetweenHandDeadzoneTrigger = 0.1f;

		private static bool _instanceCreated;

		[SerializeField]
		private MXRInputHandler _inputHandler;

		[SerializeField]
		private Transform _head;

		[SerializeField]
		private Transform _body;

		[SerializeField]
		private Transform _leftHand;

		[SerializeField]
		private Transform _rightHand;

		[SerializeField]
		private PlayerLocomotion _locomotion;

		[SerializeField]
		private Rigidbody _rigidbody;

		[SerializeField]
		private GameObject _lookingActivator;

		[SerializeField]
		private PlayerCameraSwitcher _cameraSwitcher;

		[SerializeField]
		private AddConstantForce _addConstantForce;

		[SerializeField]
		private PortalTraveller _headTraveller;

		[SerializeField]
		private Interactor _creationModeInteractor;

		[SerializeField]
		private Canvas _infoCanvas;

		[SerializeField]
		private float _movementDisableTimeFromExplosion;

		private readonly Cooldown _creationModeTurningCooldown;

		private IMessageSubscriber _playerInputModeChangedSubscriber;

		[SerializeField]
		private LocalPlayerAddExtraForceFromHit _addExtraForceFromHit;

		private PlayerVisualsController _playerVisualsController;

		[SerializeField]
		private Moon.InputSystem.PlayerInput _playerInput;

		[SerializeField]
		private InputActionReference _handMenuAction;

		[SerializeField]
		private InputActionReference _editorJumpAction;

		public float EditorJumpForce;

		private float _lastHandDeadzoneTriggerTime;

		private PlayerInputProcessor _localInputProcessor;

		public new static bool HasInstance => false;

		public MXRInputHandler InputHandler => null;

		public Transform Head => null;

		public Transform Body => null;

		public Transform LeftHand => null;

		public Transform RightHand => null;

		public PlayerLocomotion Locomotion => null;

		public Rigidbody Rigidbody => null;

		public AddConstantForce AddConstantForce => null;

		public Canvas InfoCanvas => null;

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

		public event Action OnFallsToGround
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

		public event Action<IDeadzoneInfo> OnCollideWithDeadZone
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

		public event Func<Vector3, Quaternion, bool> PortalRequestTeleport
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

		public event Action<Vector3, Quaternion, PlayerTeleportType> OnBeforeTeleport
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

		public event Action<Vector3, Quaternion, PlayerTeleportType> OnAfterTeleport
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

		public event Action OnRequestToggleHandMenu
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

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public void ResetLocalPlayer()
		{
		}

		private void LocalPlayerSharedData_OnActiveCameraChanged(Camera activeCamera, GameCameraType cameraType)
		{
		}

		private bool GetBillboardFacingTarget(out Transform target)
		{
			target = null;
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnInputFocusChanged(bool hasFocus)
		{
		}

		private int HandleOnInputModeChanged(IMessage<Moon.InputSystem.PlayerInput.InputModeChangedMessage> message)
		{
			return 0;
		}

		private bool HandleRequestCrossPortal(TravellerPortal fromPortal, float fromSide)
		{
			return false;
		}

		private void HandleHandColliding(Transform hand, bool isLeft, RaycastHit hitInfo)
		{
		}

		private void Update()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void InvokeOnCollideWithDeadZone(IDeadzoneInfo deadzoneInfo)
		{
		}

		public void Teleport(Transform otherPlace, bool keepVelocity = false, bool freezeAfterTeleport = false, PlayerTeleportType teleportType = PlayerTeleportType.Portal)
		{
		}

		public void CalculateTeleportPosition(Transform thisPlace, Transform otherPlace, out Vector3 bodyPos, out Quaternion bodyRot)
		{
			bodyPos = default(Vector3);
			bodyRot = default(Quaternion);
		}

		public Vector3 GetTeleportableTransformPosition()
		{
			return default(Vector3);
		}

		public void Teleport(Transform thisPlace, Transform otherPlace, bool keepVelocity = false, bool freezeAfterTeleport = false)
		{
		}

		public void Teleport(Transform thisPlace, Transform otherPlace, bool keepVelocity, bool freezeAfterTeleport, PlayerTeleportType teleportType)
		{
		}

		public void Teleport(Vector3 bodyWorldPos, Quaternion bodyWorldRot, bool keepVelocity = false, bool freezeAfterTeleport = false, PlayerTeleportType teleportType = PlayerTeleportType.Portal)
		{
		}

		public void DisableMovement(string source, float duration = -1f)
		{
		}

		public void EnableLookingActivator(bool enable)
		{
		}

		public void TryChangeInputMode(Moon.InputSystem.PlayerInput.Mode inputMode)
		{
		}

		public ICommand ExecuteCommand(ICommand command)
		{
			return null;
		}

		public void SetLocomotionConfiguration(PlayerLocomotionConfiguration locomotionConfiguration)
		{
		}

		public void ToggleExternalForceApplication(bool allow)
		{
		}

		private void UpdateCreationModeInputActions()
		{
		}

		private void UpdateCreationModeMovement()
		{
		}

		private void UpdateCreationModeInteractions()
		{
		}

		private void HandleOnLoadPlaceable(Action callback)
		{
		}

		private void HandleOnCancelLoadPlaceable()
		{
		}

		public void SetLeftHandPositionRotation(Transform leftHand)
		{
		}

		public void SetRightHandPositionRotation(Transform rightHand)
		{
		}

		public void SetHeadPositionRotation(Transform head)
		{
		}

		public void SetBodyPositionRotation(Transform body)
		{
		}

		public PlayerVisualsController ObtainPlayerController()
		{
			return null;
		}

		private void LateUpdate()
		{
		}
	}
}
