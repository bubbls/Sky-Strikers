using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialAppFollowersPage : PlayerPadSocialAppBasePage
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetFollowersListAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerPadSocialAppFollowersPage _003C_003E4__this;

			private TaskAwaiter<GetFollowersListResponseData> _003C_003Eu__1;

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
		private struct _003CInitializeFollowersEntries_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerPadSocialAppFollowersPage _003C_003E4__this;

			private TaskAwaiter<GetFollowersListResponseData> _003C_003Eu__1;

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

		private readonly List<PlayerPadSocialAppFollowerEntry> _followersEntries;

		private bool _isRequestingFollowPlayer;

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

		protected override void InitializeInternal()
		{
		}

		public override void UpdateTabButtonText()
		{
		}

		public override void SetDefaultState()
		{
		}

		protected override void HandleOnPageShow()
		{
		}

		[AsyncStateMachine(typeof(_003CInitializeFollowersEntries_003Ed__9))]
		private void InitializeFollowersEntries()
		{
		}

		private void ResetFriendEntries()
		{
		}

		[AsyncStateMachine(typeof(_003CGetFollowersListAsync_003Ed__11))]
		private void GetFollowersListAsync()
		{
		}

		private void UpdateFollowersEntries(List<FollowerEntry> followersList)
		{
		}

		private void HandleOnFollowPlayerButtonPressed(PlayerPadSocialAppFollowerEntry entry)
		{
		}

		private void FollowPlayer(PlayerPadSocialAppFollowerEntry entry)
		{
		}

		private void ToggleButtonInteractions(bool enable)
		{
		}
	}
}
