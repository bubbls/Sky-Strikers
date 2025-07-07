using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Player.Pad
{
	public abstract class PlayerPadAppSubView : MonoBehaviour
	{
		[SerializeField]
		private UIButton _backButton;

		public bool IsOnScreen => false;

		public event Action OnViewClosed
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

		protected virtual void InitializeInternal()
		{
		}

		public void ShowView()
		{
		}

		protected abstract void ShowViewInternal();

		private void HideView()
		{
		}

		protected abstract void HideViewInternal();
	}
}
