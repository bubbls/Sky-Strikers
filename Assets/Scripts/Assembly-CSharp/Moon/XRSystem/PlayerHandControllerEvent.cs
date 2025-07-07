using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Moon.XRSystem
{
	public class PlayerHandControllerEvent : MonoBehaviour
	{
		[SerializeField]
		private InputActionReference _actionReference;

		[SerializeField]
		private UnityEvent _onStarted;

		[SerializeField]
		private UnityEvent _onPerformed;

		[SerializeField]
		private UnityEvent _onCanceled;

		public event UnityAction OnStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction OnPerformed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction OnCanceled
		{
			add
			{
			}
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

		private void HandleInputAction(InputAction.CallbackContext ctx)
		{
		}
	}
}
