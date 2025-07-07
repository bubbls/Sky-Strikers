using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Moon.Arena;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Shop.TryOn
{
	public abstract class ShopTryMeButton : MonoBehaviour
	{
		public enum TryMeButtonState
		{
			Disabled = 0,
			TryMe = 1,
			Equip = 2,
			Equipped = 3
		}

		[SerializeField]
		private ShopTryMeButtonVisuals _visuals;

		[SerializeField]
		private DOTweenAnimation? _dtAnim;

		private TeamNo _teamNo;

		protected TryMeButtonState State { get; private set; }

		public event Action<TeamNo>? OnButtonPressed
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

		public void Initialize(TeamNo teamNo)
		{
		}

		protected abstract void HandleInitialize();

		public void ToggleButtonState(TryMeButtonState state)
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		protected void SendOnButtonPressedEvent()
		{
		}
	}
}
