using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using Chamber8.Framework.Service.PlayFab;
using PlayFab;
using PlayFab.ClientModels;

namespace Moon.Player.Pad
{
	public class SocialService : IInitializer
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetFollowersList_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetFollowersListResponseData> _003C_003Et__builder;

			public SocialService _003C_003E4__this;

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
		private struct _003CGetFollowingPlayersOnlineState_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetFollowingPlayersOnlineStateResponseData> _003C_003Et__builder;

			public SocialService _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSearchPlayerByName_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<SearchPlayerResponseData> _003C_003Et__builder;

			public SocialService _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTryDeleteFollowerRecord_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<TryDeleteFollowerRecordResponseData> _003C_003Et__builder;

			public SocialService _003C_003E4__this;

			public string followingPlayerPlayFabId;

			private TaskAwaiter<TryDeleteFollowerRecordResponseData> _003C_003Eu__1;

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
		private struct _003CTryDeleteFollowerRecordAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public SocialService _003C_003E4__this;

			public string followingPlayerPlayFabId;

			public Action callback;

			private TaskAwaiter<TryDeleteFollowerRecordResponseData> _003C_003Eu__1;

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
		private struct _003CTryRecordFollower_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<TryRecordFollowerResponseData> _003C_003Et__builder;

			public SocialService _003C_003E4__this;

			public string followingPlayFabId;

			public string followerPlayerName;

			private TaskAwaiter<TryRecordFollowerResponseData> _003C_003Eu__1;

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
		private struct _003CTryRecordFollowerAsync_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public SocialService _003C_003E4__this;

			public string followingPlayerPlayFabId;

			public string followerPlayerName;

			public Action callback;

			private TaskAwaiter<TryRecordFollowerResponseData> _003C_003Eu__1;

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
		private struct _003CUpdatePlayerSocialPrivacySetting_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<UpdatePlayerSocialPrivacySettingsResponseData> _003C_003Et__builder;

			public SocialService _003C_003E4__this;

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

		private PlayFabCloudScriptInstanceAPI _cloudScriptInstanceAPI;

		private PlayFabAccountService _accountService;

		private PlayFabClientInstanceAPI _clientInstanceAPI;

		private const string SearchPlayerRequestDataKey = "SearchPlayerData";

		private const string TryRecordFollowerRequestDataKey = "TryRecordFollowerData";

		private const string TryDeleteFollowerRecordRequestDataKey = "TryDeleteFollowerRecordData";

		private const string UpdatePlayerSocialPrivacySettingsRequestDataKey = "UpdatePlayerSocialPrivacySettingsData";

		public List<FriendInfo> FollowingPlayersList { get; private set; }

		public List<FollowerEntry> FollowersList { get; private set; }

		public void Initialize()
		{
		}

		public void UpdateLocalFollowingPlayersList(string playFabId, string playerName)
		{
		}

		[AsyncStateMachine(typeof(_003CSearchPlayerByName_003Ed__17))]
		public Task<SearchPlayerResponseData> SearchPlayerByName(string searchPlayerName)
		{
			return null;
		}

		public void SyncTitleAllPlayers()
		{
		}

		public void FollowPlayer(string followingPlayerPlayFabId, string followerPlayerName, Action<bool> callback)
		{
		}

		[AsyncStateMachine(typeof(_003CTryRecordFollowerAsync_003Ed__20))]
		private void TryRecordFollowerAsync(string followingPlayerPlayFabId, string followerPlayerName, Action callback)
		{
		}

		[AsyncStateMachine(typeof(_003CTryRecordFollower_003Ed__21))]
		private Task<TryRecordFollowerResponseData> TryRecordFollower(string followingPlayFabId, string followerPlayerName)
		{
			return null;
		}

		public void UnfollowPlayer(string followingPlayerPlayFabId, Action<bool> callback)
		{
		}

		[AsyncStateMachine(typeof(_003CTryDeleteFollowerRecordAsync_003Ed__23))]
		private void TryDeleteFollowerRecordAsync(string followingPlayerPlayFabId, Action callback)
		{
		}

		[AsyncStateMachine(typeof(_003CTryDeleteFollowerRecord_003Ed__24))]
		private Task<TryDeleteFollowerRecordResponseData> TryDeleteFollowerRecord(string followingPlayerPlayFabId)
		{
			return null;
		}

		public void GetFollowingPlayersList(Action<GetFollowingsListResponseData> callback)
		{
		}

		[AsyncStateMachine(typeof(_003CGetFollowersList_003Ed__26))]
		public Task<GetFollowersListResponseData> GetFollowersList()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetFollowingPlayersOnlineState_003Ed__27))]
		public Task<GetFollowingPlayersOnlineStateResponseData> GetFollowingPlayersOnlineState()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdatePlayerSocialPrivacySetting_003Ed__28))]
		public Task<UpdatePlayerSocialPrivacySettingsResponseData> UpdatePlayerSocialPrivacySetting(string socialPrivacyState)
		{
			return null;
		}
	}
}
