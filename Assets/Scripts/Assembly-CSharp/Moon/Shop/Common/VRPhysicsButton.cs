using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DP.Takeaway.Sound;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Shop.Common
{
	public class VRPhysicsButton : MonoBehaviour
	{
		public enum ButtonState
		{
			None = 0,
			Idle = 1,
			Pressed = 2,
			Recover = 3,
			Disable = 4
		}

		[SerializeField]
		private GameObject _interactionGameObject;

		[SerializeField]
		private Rigidbody _rigidbody;

		[SerializeField]
		private GameObject _uiMiddleContainer;

		[SerializeField]
		private VRPhysicsButtonInteraction _buttonInteraction;

		[SerializeField]
		private SoundInfo _sfxHandTouches;

		[SerializeField]
		private SoundInfo _sfxHandTouchesWhileDisabled;

		[SerializeField]
		private bool _isSpringButton;

		[SerializeField]
		[ShowIf("_isSpringButton")]
		private float _springBackSpeed;

		private const float DefaultEndYValue = -0.06f;

		[SerializeField]
		private float _endYValue;

		private RigidbodyConstraints _rigidbodyOriginalConstraints;

		private ButtonState _currentButtonState;

		private Vector3 _originalLocalPosition;

		private Transform _interactionTransform;

		private bool _isInitialized;

		private Sequence _sequence;

		private float EndYValue => 0f;

		public event Action<ButtonState> OnButtonPressed
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

		public event Action OnSpringButtonTriggering
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

		public event Action OnSpringButtonReleased
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Initialize()
		{
		}

		public void ToggleButtonInteraction(bool enable)
		{
		}

		public void Disable(bool animate)
		{
		}

		public void SetButtonPressed()
		{
		}

		public void ToggleButtonRecover(bool enable)
		{
		}

		private void Update()
		{
		}

		private void ToggleButtonMovement(bool enable)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void HandleOnPlayerHandEnter(bool isHandEnter)
		{
		}

		private void OnDestroy()
		{
		}

		private void TryKillSequence()
		{
		}
	}
}
