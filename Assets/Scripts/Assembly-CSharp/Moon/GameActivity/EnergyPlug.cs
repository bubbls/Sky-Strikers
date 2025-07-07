using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DP.Takeaway.Game;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.GameActivity
{
	public class EnergyPlug : MonoBehaviour
	{
		public enum State
		{
			Error = 0,
			WaitForRecharging = 1,
			ReadyToResearch = 2,
			ResearchDoneAndEquipped = 3,
			NotEquipped = 4
		}

		[SerializeField]
		private Transform _rootPivot;

		[SerializeField]
		private Transform _pivotPushed;

		[SerializeField]
		private Transform _pivotMiddle;

		[SerializeField]
		private Transform _pivotNotPushed;

		[SerializeField]
		private MeshRenderer _energyRenderer;

		[SerializeField]
		private MeshRenderer _equipRenderer;

		[SerializeField]
		private Trigger _trigger;

		[SerializeField]
		private SoundInfo _sfxPress;

		[SerializeField]
		private SoundInfo _sfxPressConfirm;

		[SerializeField]
		private SoundInfo _sfxClick;

		private static readonly int _paramLevelingWidth;

		private State _state;

		private Sequence _sequence;

		private Material _energyMaterial;

		private Material _equipMaterial;

		private Tween _progressTween;

		private Tween _rootPivotTween;

		public event Action<EnergyPlug, Action<bool>> RequestResearch
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

		public event Action<EnergyPlug, bool> RequestEquip
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetProgress(float progress)
		{
		}

		public void SetState(State state)
		{
		}

		private void HandleTriggered(Collider _)
		{
		}

		private void PressToEquip(bool equip)
		{
		}

		private void PressToResearch()
		{
		}

		private void PressedWhenNotReady()
		{
		}
	}
}
