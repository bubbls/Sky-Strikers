using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using PlayFab;

namespace Moon.Bootstrap
{
	public class RemoteConfigContainer : Singleton<RemoteConfigContainer>
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass22_0<T> where T : notnull
		{
			public RemoteConfigContainer _003C_003E4__this;

			public string key;

			public TaskCompletionSource<bool> tcs;

			internal void _003CGetAsync_003Eb__0(string value)
			{
			}

			internal void _003CGetAsync_003Eb__1(PlayFabError _)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAsync_003Ed__22<T> : IAsyncStateMachine where T : notnull
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			public RemoteConfigContainer _003C_003E4__this;

			public string key;

			private _003C_003Ec__DisplayClass22_0<T> _003C_003E8__1;

			private TaskAwaiter<bool> _003C_003Eu__1;

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
		private struct _003CInitializeAsync_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RemoteConfigContainer _003C_003E4__this;

			public CancellationToken cancellationToken;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private object _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private ValueTaskAwaiter _003C_003Eu__2;

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

		private const string CacheKeyPrefixKey = "RemoteConfigContainer";

		public const string DiscordInviterUrl = "DiscordInviteUrl";

		public const string SipletsSettings = "SipletsSettings";

		public const string XpSystemConfig = "XpSystemConfig";

		public const string TeaseConfig = "TeaseConfig";

		public const string NewUserJourney = "NewUserJourney";

		public const string ReferralRewards = "ReferralRewards";

		public const string HubGameSettingsConfigurations = "HubGameSettingsConfigurations";

		public const string MMRScalingTable = "MMRScalingTable";

		public const string MMRLevelsTable = "MMRLevelsTable";

		public const string MMRGroupsInfoTable = "MMRGroupsInfoTable";

		public const string RankedRemoteConfig = "RankedRemoteConfig";

		public const string RatingThresholdConfig = "RatingThresholdConfig";

		public const string PrivateQueueConfig = "PrivateQueueConfig";

		public const string HofHighlights = "HofHighlights";

		private readonly List<string> _keys;

		private readonly Dictionary<string, string> _lookup;

		private readonly Dictionary<string, TaskCompletionSource<bool>> _requests;

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__18))]
		public Task InitializeAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public T? Get<T>(string key, T? defaultValue = default(T?))
		{
			return default(T);
		}

		public bool TryGet<T>(string key, out T? result)
		{
			result = default(T);
			return false;
		}

		public bool TryGetRawData(string key, out string result)
		{
			result = null;
			return false;
		}

		[AsyncStateMachine(typeof(_003CGetAsync_003Ed__22<>))]
		public Task<T> GetAsync<T>(string key) where T : notnull
		{
			return null;
		}
	}
}
