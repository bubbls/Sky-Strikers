using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Service.PlayFab;
using Moon.Arena;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialApp : PlayerPadApp, IScrollablePlayerPadApp
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdatePlayerSocialPrivacyStateAsync_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerPadSocialApp _003C_003E4__this;

			public string socialPrivacyState;

			private TaskAwaiter<UpdatePlayerSocialPrivacySettingsResponseData> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		private TMP_Text _playerNameText;

		[SerializeField]
		private PlayerPadSocialAppTabController _socialTabController;

		[SerializeField]
		private PlayerPadSocialAppSearchPage _searchPage;

		private IPlayFabAccountService _accountService;

		private SocialService _socialService;

		private GameOption.SocialPrivacyState _currentSocialPrivacyState;

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

		private void HandleOnOptionsSaved(GameOption.Options options)
		{
		}

		[AsyncStateMachine(typeof(_003CUpdatePlayerSocialPrivacyStateAsync_003Ed__18))]
		private void UpdatePlayerSocialPrivacyStateAsync(string socialPrivacyState)
		{
		}

		private void TabController_HandleOnTogglePopupOnTop(bool isShowing)
		{
		}

		private void SearchPage_HandleOnToggleSearchPage(bool isShowing)
		{
		}

		protected override void HandleAppAboutToOpenInternal(IPlayerPadAppOpenData appOpenData)
		{
		}

		private void SearchPage_HandleOnFollowedPlayer()
		{
		}

		private void TabController_HandleOnSwitchScrollRect(ScrollRect currentScrollRect, ScrollRect targetScrollRect)
		{
		}

		protected override void HandleAppOpenCompleteInternal()
		{
		}

		protected override void HandleAppAboutToCloseInternal()
		{
		}

		private void RequestRegisterScrollRectInternal(ScrollRect scrollRect)
		{
		}

		private void RequestUnRegisterScrollRectInternal(ScrollRect scrollRect)
		{
		}
	}
}
