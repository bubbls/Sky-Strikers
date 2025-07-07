using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DP.Takeaway.Game;
using DP.Takeaway.Sound;
using TMPro;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVIncreaseDecreaseButton : MonoBehaviour
	{
		private enum Mode
		{
			None = 0,
			Increase = 1,
			Decrease = 2
		}

		[SerializeField]
		private int _defaultValue;

		[SerializeField]
		private int _minValue;

		[SerializeField]
		private int _maxValue;

		[SerializeField]
		private int _deltaValue;

		[SerializeField]
		private ColorConfig _textColorConfig;

		[SerializeField]
		private TMP_Text _valueText;

		[SerializeField]
		private TMP_Text _minusText;

		[SerializeField]
		private TMP_Text _plusText;

		[SerializeField]
		private Transform _visual;

		[SerializeField]
		private GameObject _ui;

		[SerializeField]
		private bool _isAnimated;

		[SerializeField]
		private float _animateDuration;

		[SerializeField]
		private float _increaseYRotation;

		[SerializeField]
		private float _decreaseYRotation;

		[SerializeField]
		private Trigger _increaseTrigger;

		[SerializeField]
		private Trigger _decreaseTrigger;

		[SerializeField]
		private float _rayCheckDistance;

		[Header("Sound")]
		[SerializeField]
		private SoundInfo _pressedSoundInfo;

		private Sequence _sequence;

		private bool _canPress;

		private bool _canDoRayCheck;

		private int _currentValue;

		private Transform _rayCheckTransform;

		private Vector3 _startPosition;

		private Mode _currentMode;

		private bool _isActive;

		private Ray _ray;

		private readonly RaycastHit[] _hits;

		private int _hitCount;

		public int CurrentValue => 0;

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

		public void ToggleActivation(bool isActive)
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void HandleOnIncreaseTriggerEnter(Collider other)
		{
		}

		private void HandleOnIncreaseTriggerExit(Collider other)
		{
		}

		private void HandleOnDecreaseTriggerEnter(Collider other)
		{
		}

		private void HandleOnDecreaseTriggerExit(Collider other)
		{
		}

		private void ReleaseButton()
		{
		}

		private void UpdateValue(int delta = 0)
		{
		}

		private bool CheckCanPress(Transform otherTransform)
		{
			return false;
		}

		private void TryGenerateSequence(float yRotation, Action callback = null)
		{
		}

		private void OnDestroy()
		{
		}

		public void PressNearestToPoint(Vector3 point)
		{
		}
	}
}
