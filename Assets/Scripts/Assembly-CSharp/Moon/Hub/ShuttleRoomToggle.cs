using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DP.Takeaway.Game;
using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using UnityEngine;

namespace Moon.Hub
{
	public class ShuttleRoomToggle : MonoBehaviour
	{
		[SerializeField]
		private Trigger _trigger;

		[SerializeField]
		private Transform _knot;

		[SerializeField]
		private Transform _onPivot;

		[SerializeField]
		private Transform _offPivot;

		[SerializeField]
		private SoundPlayerStub _sfxToggle;

		private bool _isOn;

		private Tween _tween;

		private readonly Cooldown _triggerCd;

		private readonly HashSet<Collider> _colliders;

		public bool IsOn => false;

		public event Action OnValueChanged
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

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleTriggerEnter(Collider col)
		{
		}

		private void HandleTriggerExit(Collider col)
		{
		}

		private void UpdateVisual(bool immediate = false)
		{
		}

		public void ForceToggle(bool isOn, bool immediate = false)
		{
		}

		public void Toggle()
		{
		}
	}
}
