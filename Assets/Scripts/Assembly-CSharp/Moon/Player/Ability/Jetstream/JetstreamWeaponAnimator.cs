using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	public abstract class JetstreamWeaponAnimator : MonoBehaviour
	{
		protected bool AnimationsEnabled { get; private set; }

		public event Action OnAnimateOutComplete
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

		public abstract void Initialize(PlayerVisualAttachPointType attachPointType);

		public abstract void AnimateIn();

		public abstract void AnimateOut();

		public void DisableAnimations()
		{
		}

		protected void NotifyAnimateOutComplete()
		{
		}

		public abstract void HandleOnBallEnteredWeaponArea(Transform ball);

		public abstract void HandleBallBlastAreaStatusChanged(bool isBallInBlastArea);

		public abstract void HandleOnBallExitWeaponArea();

		public abstract void EnterBallShotState(Transform ballTransform, float ballControlDuration);

		public abstract void AnimateSuckingRange(float t);
	}
}
