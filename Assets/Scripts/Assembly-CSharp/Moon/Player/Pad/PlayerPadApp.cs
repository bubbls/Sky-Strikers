using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Moon.Player.Pad
{
	public abstract class PlayerPadApp : MonoBehaviour
	{
		private Sequence _animateSequence;

		private bool _isAnimating;

		private bool _isShowing;

		public abstract PlayerPadAppID AppID { get; }

		public event Action OnRequestDisableApp
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

		public event Action OnRequestEnableApp
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

		public virtual void Initialize()
		{
		}

		public virtual void Dispose()
		{
		}

		protected abstract void InitializeInternal();

		private void OnDisable()
		{
		}

		public void OpenApp(IPlayerPadAppOpenData appOpenData, float duration, Vector3 startPos, Action onAppOpened)
		{
		}

		protected abstract void HandleAppAboutToOpenInternal(IPlayerPadAppOpenData appOpenData);

		protected virtual void HandleAppOpenCompleteInternal()
		{
		}

		public void CloseApp(Vector2 endPosition, float appCloseDuration, Action onAppClosed)
		{
		}

		protected abstract void HandleAppAboutToCloseInternal();

		public virtual void HandleAppOpenedFromNotification(IPlayerPadAppOpenData appOpenData)
		{
		}

		protected void RequestDisableApp()
		{
		}

		protected void RequestEnableApp()
		{
		}
	}
}
