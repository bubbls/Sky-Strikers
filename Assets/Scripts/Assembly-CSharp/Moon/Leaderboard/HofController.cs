using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Service.PlayFab.PlayerData;
using Moon.Class;
using Moon.Framework.Leaderboard;
using PlayFab.ClientModels;
using UnityEngine;

namespace Moon.Leaderboard
{
	public class HofController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public HofSlotData slotData;

			public TaskCompletionSource<bool> tcs1;

			public TaskCompletionSource<bool> tcs2;

			internal void _003CHandleRequestLeaderboardAsync_003Eb__0(IEnumerable<LeaderboardEntry> entries)
			{
			}

			internal void _003CHandleRequestLeaderboardAsync_003Eb__1()
			{
			}

			internal void _003CHandleRequestLeaderboardAsync_003Eb__2(IEnumerable<LeaderboardEntry> entries)
			{
			}

			internal void _003CHandleRequestLeaderboardAsync_003Eb__3()
			{
			}

			internal bool _003CHandleRequestLeaderboardAsync_003Eb__4(LeaderboardEntry e)
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CHandleRequestLeaderboardAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Action<HofSlotData?> complete;

			public HofSlot slot;

			private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

			public HofController _003C_003E4__this;

			public int topN;

			private TaskAwaiter<HofSlots?> _003C_003Eu__1;

			private TaskAwaiter<bool[]> _003C_003Eu__2;

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
		private struct _003CHandleRequestPlayerVisualConfig_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public HofController _003C_003E4__this;

			public string playFabId;

			public Action<PlayerVisualsCachedConfigsData?> complete;

			private TaskAwaiter<Dictionary<string, UserDataRecord>?> _003C_003Eu__1;

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

		private const string HofSlotsKey = "HofSlots";

		private static readonly TimeSpan _refreshTime;

		[SerializeField]
		private HofLeaderboard[] _leaderboards;

		[SerializeField]
		private PlayerVisualsPresetPointsProvider _presetPointsProvider;

		private ILeaderboardClient _leaderboardClient;

		private PlayFabPlayerDataClient _playerDataClient;

		private int _timerId;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void RefreshController()
		{
		}

		private void OnDisable()
		{
		}

		[AsyncStateMachine(typeof(_003CHandleRequestLeaderboardAsync_003Ed__11))]
		private void HandleRequestLeaderboardAsync(HofSlot slot, int topN, Action<HofSlotData?> complete)
		{
		}

		[AsyncStateMachine(typeof(_003CHandleRequestPlayerVisualConfig_003Ed__12))]
		private void HandleRequestPlayerVisualConfig(string playFabId, Action<PlayerVisualsCachedConfigsData?> complete)
		{
		}

		private PlayerVisualsPresetPoints? HandleRequestPresetContainer(PlayerSuitClass arg)
		{
			return null;
		}
	}
}
