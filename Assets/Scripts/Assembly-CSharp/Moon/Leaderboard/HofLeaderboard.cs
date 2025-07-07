using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Moon.Class;
using Moon.Framework.Leaderboard;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Leaderboard
{
	public class HofLeaderboard : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CHandleLeaderboardRefreshed_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public HofLeaderboard _003C_003E4__this;

			public HofSlotData? slotData;

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
		private struct _003CInitializeInternalAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public HofLeaderboard _003C_003E4__this;

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
		private struct _003CStart_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public HofLeaderboard _003C_003E4__this;

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
		private struct _003CUpdateStatues_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public HofSlotData? slotData;

			public HofLeaderboard _003C_003E4__this;

			private int _003Ci_003E5__2;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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

		private const int InitialRefreshDelay = 8;

		[SerializeField]
		private HofSlot _hofSlot;

		[SerializeField]
		private int _topN;

		[SerializeField]
		private PlayerVisualsPresetSlot[] _statues;

		[SerializeField]
		private HofLeaderboardUI? _leaderboardUI;

		public Action<HofSlot, int, Action<HofSlotData?>>? RequestLeaderboard;

		public Action<string, Action<PlayerVisualsCachedConfigsData?>>? RequestPlayerVisualConfig;

		public Func<PlayerSuitClass, PlayerVisualsPresetPoints?>? RequestPresetContainer;

		private int _timerId;

		private bool _initialized;

		private bool _canUpdate;

		private int LeaderBoardTopN => 0;

		[AsyncStateMachine(typeof(_003CStart_003Ed__13))]
		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CInitializeInternalAsync_003Ed__14))]
		private void InitializeInternalAsync()
		{
		}

		private void OnDestroy()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void Refresh()
		{
		}

		[AsyncStateMachine(typeof(_003CHandleLeaderboardRefreshed_003Ed__17))]
		private void HandleLeaderboardRefreshed(HofSlotData? slotData)
		{
		}

		private void UpdateUI(HofSlotData? slotData)
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateStatues_003Ed__19))]
		private Task UpdateStatues(HofSlotData? slotData)
		{
			return null;
		}

		private void UnloadStatue(int i)
		{
		}

		private bool TryLoadStatue(HofSlotData slotData, int index)
		{
			return false;
		}

		private void LoadStatueInternal(int index, PlayerSuitClass preferredSuitClass, LeaderboardEntry entry, PlayerVisualsCachedConfigsData? data)
		{
		}
	}
}
