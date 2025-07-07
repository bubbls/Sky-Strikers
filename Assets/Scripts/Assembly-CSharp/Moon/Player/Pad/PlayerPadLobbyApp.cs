using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class PlayerPadLobbyApp : PlayerPadApp, IScrollablePlayerPadApp
	{
		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private PlayerPadPlayerListConsole _playerListConsole;

		public override PlayerPadAppID AppID => default(PlayerPadAppID);

		public ScrollRect ScrollRect => null;

		public event Action<ScrollRect> OnRequestRegisterScrollRect
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

		public event Action<ScrollRect> OnRequestUnRegisterScrollRect
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

		protected override void InitializeInternal()
		{
		}

		protected override void HandleAppAboutToOpenInternal(IPlayerPadAppOpenData appOpenData)
		{
		}

		protected override void HandleAppOpenCompleteInternal()
		{
		}

		protected override void HandleAppAboutToCloseInternal()
		{
		}
	}
}
