using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialAppFollowingPlayersPage : PlayerPadSocialAppBasePage
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetFollowingPlayersOnlineState_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerPadSocialAppFollowingPlayersPage _003C_003E4__this;

			private TaskAwaiter<GetFollowingPlayersOnlineStateResponseData> _003C_003Eu__1;

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
		private GameObject _timerVisual;

		[SerializeField]
		private Image _timerFillImage;

		[SerializeField]
		private TMP_Text _timerText;

		[SerializeField]
		private float _updateFollowingPlayersOnlineStateInterval;

		[SerializeField]
		[Header("UnfollowPopup")]
		private GameObject _unfollowPopup;

		[SerializeField]
		private UIInputKeyboardButton _unfollowPopupConfirmButton;

		[SerializeField]
		private UIButton _unfollowPopupCancelButton;

		private List<PlayerPadSocialAppFollowingPlayerEntry> _followingEntries;

		private bool _isRequestingUnfollowPlayer;

		private string _currentUnfollowPlayerPlayFabId;

		private bool _canUpdateFollowingPlayersOnlineState;

		private float _updateFollowingPlayersOnlineStateTimer;

		public event Action<bool> OnToggleUnfollowPopup
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

		public override void UpdateTabButtonText()
		{
		}

		public override void SetDefaultState()
		{
		}

		private void Update()
		{
		}

		private void InitializeFollowingEntries()
		{
		}

		protected override void HandleOnEnable()
		{
		}

		protected override void HandleOnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void HandleOnUnfollowButtonPressed(string playFabId)
		{
		}

		private void HandleOnUnfollowPopupConfirmButtonPressed()
		{
		}

		private void HandleOnUnfollowPopupCancelButtonPressed()
		{
		}

		private void HandleOnUnfollowCallbackAsync(bool isSucceed)
		{
		}

		private void CompleteUnfollowPlayer()
		{
		}

		private void ResetFollowingPlayersEntries()
		{
		}

		protected override void HandleOnPageShow()
		{
		}

		protected override void HandleOnPageHide()
		{
		}

		private void GetFollowingPlayersList()
		{
		}

		private void UpdateFollowingPlayersEntries(List<FriendInfo> friendsList)
		{
		}

		[AsyncStateMachine(typeof(_003CGetFollowingPlayersOnlineState_003Ed__33))]
		private void GetFollowingPlayersOnlineState()
		{
		}

		private void ToggleButtonsInteraction(bool enable)
		{
		}
	}
}
