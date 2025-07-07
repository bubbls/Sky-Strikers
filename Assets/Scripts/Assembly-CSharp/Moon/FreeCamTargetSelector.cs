using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Moon
{
	public class FreeCamTargetSelector : MonoBehaviour
	{
		[SerializeField]
		private InputActionReference _selectNextTargetInputAction;

		[SerializeField]
		private InputActionReference _selectPreviousTargetInputAction;

		private readonly List<MPlayer> _players;

		private PlayerRef _focusedPlayer;

		private Transform _playerTransform;

		private bool _isFocusedOnBall;

		private Transform _ballTransform;

		private bool _inputListeningEnabled;

		public event Action<Transform> OnNewTargetSelected
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		private void SelectNextTarget_OnPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void SelectPreviousTarget_OnPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void GetTargetToFocusOn(bool increment)
		{
		}

		public void FocusOnLocalPlayer()
		{
		}

		public void ToggleInputListening(bool enable)
		{
		}

		private int GetCurrentFocusedPlayerIndex()
		{
			return 0;
		}

		private void GetNextPlayerToFocusOn(bool next)
		{
		}

		private void SelectPlayer(int index)
		{
		}

		private bool TryFindBallTransform(out Transform ballTransform)
		{
			ballTransform = null;
			return false;
		}
	}
}
