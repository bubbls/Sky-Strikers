using Chamber8.Framework.Common;
using UnityEngine;
using UnityEngine.InputSystem;
using VRKeys;

namespace Moon
{
	public class VRInspectMode : SingleMonoBehaviour<VRInspectMode, InSceneSingleMonoBehaviourSettings>
	{
		private const string ClassName = "VRInspectMode";

		[SerializeField]
		private InputActionReference _leftTrigger;

		[SerializeField]
		private InputActionReference _rightTrigger;

		[SerializeField]
		private InputActionReference _leftGrip;

		[SerializeField]
		private InputActionReference _rightGrip;

		[SerializeField]
		private InputActionReference _toggleRuntimeInspector;

		[SerializeField]
		private Transform _inspectorCanvasRoot;

		[SerializeField]
		private float _inspectorMoveSpeed;

		[SerializeField]
		private float _inspectorCanvasDistance;

		[SerializeField]
		private Transform _inspectorCameraTransform;

		[SerializeField]
		private VRKeys.Keyboard _vrKeyboard;

		private Vector3 _inspectorForward;

		private int _cheatCodeInputIndex;

		private InputActionReference[] _cheatCodeSequence;

		private bool _inspectMode;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetVRKeyboardParent(Transform trans)
		{
		}

		public void SetInspectorCameraTransform(Transform trans)
		{
		}

		private void HandleInputActionStarted(InputAction.CallbackContext context)
		{
		}

		[ContextMenu("Inspect Mode/Enter Inspect Mode")]
		private void EnterInspectMode()
		{
		}

		[ContextMenu("Inspect Mode/Toggle Runtime Inspector")]
		private void ToggleRuntimeInspector()
		{
		}
	}
}
