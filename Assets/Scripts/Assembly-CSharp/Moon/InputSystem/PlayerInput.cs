using System;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

namespace Moon.InputSystem
{
	public class PlayerInput : MonoBehaviour
	{
		public enum Mode
		{
			Game = 0,
			Creation = 1,
			Loading = 2,
			Observer = 3
		}

		public class InputModeChangedMessage
		{
			public Mode Mode;
		}

		public class RequestSaveOrLoadPlaceableMessage
		{
			public bool Save;
		}

		public static readonly ISubscriptionModel OnInputModeChanged;

		public static readonly ISubscriptionModel RequestSaveOrLoadPlaceable;

		[SerializeField]
		private InputActionManager _gameModeInteractions;

		[SerializeField]
		private InputActionManager _creationMode;

		[SerializeField]
		private InputActionReference _toggleInputMode;

		[SerializeField]
		private InputActionReference _savePlaceable;

		[SerializeField]
		private InputActionReference _loadPlaceable;

		private Mode _mode;

		private IMessageProducer _messageProducer;

		public static event Action<Action> OnLoadPlaceable
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

		public static event Action OnCancelLoadPlaceable
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

		private void StagingLoadingController_OnLoadingComplete()
		{
		}

		private void OnDestroy()
		{
		}

		public void TrySetInputMode(Mode inputMode)
		{
		}

		private void UpdateInputMode()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ToggleInputMode(InputAction.CallbackContext callback)
		{
		}

		private void LoadPlaceable(InputAction.CallbackContext obj)
		{
		}

		private void CancelLoadPlaceable(InputAction.CallbackContext context)
		{
		}

		private void SavePlaceable(InputAction.CallbackContext obj)
		{
		}
	}
}
