using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Moon
{
	public class MXRInputHandler : MonoBehaviour
	{
		[Serializable]
		public class Controller
		{
			public Transform Tracker;

			public InputActionReference Position;

			public InputActionReference Velocity;

			public InputActionReference Squeeze;

			public InputActionReference Grab;

			public InputActionReference FingerThumb;

			public InputActionReference FingerIndex;

			public InputActionReference FingerOthers;

			public InputActionReference Joystick;

			public InputActionReference ToggleBackpack;

			private MXRControllerInputData _data;

			public MXRControllerInputData GetInputData()
			{
				return default(MXRControllerInputData);
			}

			public void ResetInput()
			{
			}

			public void IssueDropAndUnsqueezeCommand()
			{
			}

			public void IssueDropCommand()
			{
			}

			private void ToggleInputActionFlag(bool condition, MXRInputAction inputActionFlag)
			{
			}
		}

		private const float TurnThreshold = 0.75f;

		[SerializeField]
		private Transform _headTracker;

		[SerializeField]
		private Transform _bodyTracker;

		[SerializeField]
		private Controller _leftController;

		[SerializeField]
		private Controller _rightController;

		[Header("Creation Mode")]
		[SerializeField]
		private InputActionReference _creationModeMoveHorizontally;

		[SerializeField]
		private InputActionReference _creationModeSnapTurn;

		[SerializeField]
		private InputActionReference _creationModeMoveFaster;

		[SerializeField]
		private InputActionReference _creationModeMoveTarget;

		[SerializeField]
		private InputActionReference _creationModeRotateTarget;

		[SerializeField]
		private InputActionReference _creationModeScaleTarget;

		private MXRInputData _inputData;

		private MXRInputAction _creationModeInputAction;

		private Vector2 _creationModeMoveOnEyeSightPlane;

		public Transform HeadTracker => null;

		public Transform BodyTracker => null;

		public Controller LeftController => null;

		public Controller RightController => null;

		public MXRInputData InputData => default(MXRInputData);

		private void Awake()
		{
		}

		public void ResetInput()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetInputSources(Transform head, Transform body, Transform leftHand, Transform rightHand)
		{
		}

		private void Update()
		{
		}

		public MXRInputData GetInputData()
		{
			return default(MXRInputData);
		}

		public static void TryHapticImpulse(bool leftHand, HapticImpulse hapticImpulse)
		{
		}

		public static void TryHapticImpulse(bool leftHand, float duration, float amp, float freq = 10f)
		{
		}

		public void IssueDropAndUnsqueezeCommand()
		{
		}
	}
}
