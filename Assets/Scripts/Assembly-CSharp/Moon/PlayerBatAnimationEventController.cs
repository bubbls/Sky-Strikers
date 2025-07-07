using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon
{
	public class PlayerBatAnimationEventController : MonoBehaviour
	{
		[SerializeField]
		private AnimationClip _showAnimationClip;

		[SerializeField]
		private AnimationClip _hideAnimationClip;

		private float _showAnimationClipLength;

		private float _hideAnimationClipLength;

		public event Action<bool> OnAnimationComplete
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

		public void Initialize()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private void HandleOnShowAnimationComplete()
		{
		}

		private void HandleOnHideAnimationComplete()
		{
		}
	}
}
