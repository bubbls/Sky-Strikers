using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NaughtyAttributes;
using PlayFab.ServerModels;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialAppSearchPage : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass42_0
		{
			public List<SearchPlayerEntry> searchPlayerEntries;

			public int position;

			public int maxResultsCount;

			public PlayerPadSocialAppSearchPage _003C_003E4__this;

			internal void _003CDebugGetLeaderboardPlayersCallback_003Eb__0(GetLeaderboardResult result)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDebugGetLeaderboardPlayersCallback_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public List<SearchPlayerEntry> searchPlayerEntries;

			public int position;

			public int maxResultsCount;

			public PlayerPadSocialAppSearchPage _003C_003E4__this;

			private _003C_003Ec__DisplayClass42_0 _003C_003E8__1;

			private TaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDebugSearchPlayerByNameAsync_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerPadSocialAppSearchPage _003C_003E4__this;

			private TaskAwaiter<SearchPlayerResponseData> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSavePlayerLeaderboardEntries_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public List<SearchPlayerEntry> dataList;

			public PlayerPadSocialAppSearchPage _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSearchPlayerByNameAsync_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerPadSocialAppSearchPage _003C_003E4__this;

			public string searchPlayerName;

			private TaskAwaiter<SearchPlayerResponseData> _003C_003Eu__1;

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
		private GameObject _container;

		[SerializeField]
		private RectTransform _content;

		[Header("Search Player")]
		[SerializeField]
		private ScrollRect _searchScrollRect;

		[SerializeField]
		private UIInputKeyboardButton _toggleSearchButton;

		[SerializeField]
		private UIButton _backButton;

		[SerializeField]
		private UIInputKeyboardButton _searchButton;

		[SerializeField]
		private UIInputKeyboard _uiInputKeyboard;

		[SerializeField]
		private PlayerPadSocialAppSearchEntry[] _searchPlayerEntries;

		[Header("Debug")]
		private bool _isPageShowing;

		private bool _isSearching;

		private SocialService _socialService;

		private bool _isRequestingFollowPlayer;

		private float _lastContentTransformSize;

		private Vector3 _lastContentTransformLocalPosition;

		private bool _hasScrollRectChange;

		[SerializeField]
		private string _searchPlayerName;

		public ScrollRect SearchScrollRect => null;

		public event Action<bool> OnToggleSearchPage
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

		public event Action OnFollowedPlayer
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

		public void Initialize(SocialService socialService)
		{
		}

		public void ToggleSearchButtonInteraction(bool enable)
		{
		}

		private void ToggleUI(bool enable)
		{
		}

		public void SetDefaultState()
		{
		}

		public void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnToggleSearchButtonPressed()
		{
		}

		private void HandleOnBackButtonPressed()
		{
		}

		private void ResetSearchPlayerEntries()
		{
		}

		private void HandleOnSearchButtonPressed()
		{
		}

		[AsyncStateMachine(typeof(_003CSearchPlayerByNameAsync_003Ed__34))]
		private void SearchPlayerByNameAsync(string searchPlayerName)
		{
		}

		private void HandleOnFollowPlayerButtonPressed(PlayerPadSocialAppSearchEntry entry)
		{
		}

		private void FollowPlayer(PlayerPadSocialAppSearchEntry entry)
		{
		}

		private void ToggleButtonsInteraction(bool enable)
		{
		}

		[Button("Debug GetLeaderboardPlayers", EButtonEnableMode.Always)]
		public void DebugGetLeaderboardPlayers()
		{
		}

		[Button("Debug SyncTitleAllPlayers", EButtonEnableMode.Always)]
		public void DebugSyncTitleAllPlayers()
		{
		}

		[Button("Debug SearchPlayerByName", EButtonEnableMode.Always)]
		public void DebugSearchPlayerByName()
		{
		}

		[AsyncStateMachine(typeof(_003CDebugGetLeaderboardPlayersCallback_003Ed__42))]
		private void DebugGetLeaderboardPlayersCallback(int maxResultsCount, int position, List<SearchPlayerEntry> searchPlayerEntries)
		{
		}

		[AsyncStateMachine(typeof(_003CSavePlayerLeaderboardEntries_003Ed__43))]
		private void SavePlayerLeaderboardEntries(List<SearchPlayerEntry> dataList)
		{
		}

		private string GetFilePath()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDebugSearchPlayerByNameAsync_003Ed__45))]
		private void DebugSearchPlayerByNameAsync()
		{
		}
	}
}
