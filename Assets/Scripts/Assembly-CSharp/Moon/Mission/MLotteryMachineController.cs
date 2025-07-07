using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Backpack;
using Moon.Economy;
using Moon.Framework.Service.PlayFab.CloudScript;
using Moon.Shop;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Mission
{
	[NetworkBehaviourWeaved(1)]
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Server | SimulationModes.Host))]
	public class MLotteryMachineController : NetworkBehaviour
	{
		private enum LocalStatus
		{
			Initializing = 0,
			Working = 1,
			Broken = 2,
			BrokenFromInitialization = 3
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass38_0
		{
			public MLotteryMachineController _003C_003E4__this;

			public TaskCompletionSource<(Prize, HttpStatusCode)> tcs;

			internal void _003CLocalPlayerRequestDrawPrizeAsync_003Eb__0(Prize prize)
			{
			}

			internal void _003CLocalPlayerRequestDrawPrizeAsync_003Eb__1(CloudScriptResp<Prize> resp)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CClientRequestPrizePoolAsync_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public MLotteryMachineController _003C_003E4__this;

			private TaskAwaiter<PrizePool> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private struct _003CLocalPlayerRequestDrawPrizeAsync_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MLotteryMachineController _003C_003E4__this;

			private _003C_003Ec__DisplayClass38_0 _003C_003E8__1;

			private TaskAwaiter<Task> _003C_003Eu__1;

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
		private struct _003CServerWaitForPrintingDoneAsync_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MLotteryMachineController _003C_003E4__this;

			public List<MGrabbableBackpackItem> items;

			private TaskAwaiter<Task> _003C_003Eu__1;

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

		private const string MachineId = "Free_Lottery";

		private const int LongestVisualFeedbackTime = 10;

		private const int DrawPrizeTimeoutTime = 20;

		private const int MaxProcessingTime = 30;

		private const int BrokenRecoverTime = 5;

		[DefaultForProperty("RunningByPlayer", 0, 1)]
		private PlayerRef _RunningByPlayer;

		private LocalStatus _localStatus;

		[SerializeField]
		private LotteryMachine _lotteryMachine;

		private PriceAmount _pricePerDraw;

		private LotteryService _lotteryService;

		private PlayerEconomy _playerEconomy;

		private IMessageSubscriber[] _subscribers;

		private CancellationTokenSource _cancelCts;

		private NetworkEvents _networkEvents;

		private TaskCompletionSource<int> _printingTcs;

		private TickTimer _processingTimer;

		private TickTimer _brokenTimer;

		private bool _isInitializing;

		private bool _isInitialized;

		private static Changed<MLotteryMachineController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MLotteryMachineController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MLotteryMachineController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "HandleRunningByPlayerChanged")]
		[NetworkedWeaved(0, 1)]
		private PlayerRef RunningByPlayer
		{
			get
			{
				return default(PlayerRef);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		[Preserve]
		private static void HandleRunningByPlayerChanged(Changed<MLotteryMachineController> changed)
		{
		}

		private void RaiseRunningByPlayerChanged()
		{
		}

		private void HandleRequestDrawPrize()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private static void CreateSpawnList(Prize prize, out List<BackpackItemNetworkStruct> itemList)
		{
			itemList = null;
		}

		private bool LocalPlayerRequestPrintPrizeAsync(Prize prize)
		{
			return false;
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true)]
		private void Rpc_RequestSpawnPrize(LotteryPrizeNetworkStruct prizeData)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyBroken(HttpStatusCode errorCode)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyStartPrinting(PlayerRef playerRef, Rarity prizeCategory)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyPrinted()
		{
		}

		private void OnReachSpawnPoint()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true)]
		private void Rpc_NotifyReachSpawnPoint(PlayerRef playerRef)
		{
		}

		[AsyncStateMachine(typeof(_003CServerWaitForPrintingDoneAsync_003Ed__36))]
		private void ServerWaitForPrintingDoneAsync(PlayerRef playerRef, List<MGrabbableBackpackItem> items)
		{
		}

		private void OtherPlayerRequestDrawPrize(PlayerRef playerRef)
		{
		}

		[AsyncStateMachine(typeof(_003CLocalPlayerRequestDrawPrizeAsync_003Ed__38))]
		private void LocalPlayerRequestDrawPrizeAsync()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true)]
		private void Rpc_ReportBroken(PlayerRef playerRef, HttpStatusCode errorCode)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true)]
		private void Rpc_RequestDrawPrize(PlayerRef playerRef)
		{
		}

		public override void Spawned()
		{
		}

		private void HandleOnPlayerLeft(NetworkRunner runner, PlayerRef playerRef)
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		[AsyncStateMachine(typeof(_003CClientRequestPrizePoolAsync_003Ed__44))]
		private Task ClientRequestPrizePoolAsync()
		{
			return null;
		}

		private void SetWorking()
		{
		}

		private void SetBroken(HttpStatusCode errorCode)
		{
		}

		private void SetBrokenFromInitialization(HttpStatusCode errorCode)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 7, 1)]
		protected unsafe static void Rpc_RequestSpawnPrize_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 1, 7)]
		protected unsafe static void Rpc_NotifyBroken_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(3, 1, 7)]
		protected unsafe static void Rpc_NotifyStartPrinting_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(4, 1, 7)]
		protected unsafe static void Rpc_NotifyPrinted_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(5, 7, 1)]
		protected unsafe static void Rpc_NotifyReachSpawnPoint_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(6, 7, 1)]
		protected unsafe static void Rpc_ReportBroken_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(7, 7, 1)]
		protected unsafe static void Rpc_RequestDrawPrize_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
