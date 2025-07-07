using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using Fusion;
using JetBrains.Annotations;
using Moon.Arena;
using Moon.Bootstrap;
using Moon.MultiPlay;
using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class CustomArenaMatchConsole : MonoBehaviour
	{
		private enum LaunchMode
		{
			Player = 0,
			Observer = 1
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CShowMessage_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CustomArenaMatchConsole _003C_003E4__this;

			public string message;

			public string launchButtonText;

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

		private const int JoinCustomServerCountdownDuration = 100;

		[SerializeField]
		private int _countdownBeforeTeleportTime;

		[SerializeField]
		private ShuttleRoomRegionSelector _regionSelectorCustomGame;

		[SerializeField]
		private ManualButton _btnSwitchRegionCustomGame;

		[SerializeField]
		private ManualToggle _launchBtnCustomGame;

		[SerializeField]
		private ManualToggle _launchBtnCustomGameObserver;

		[SerializeField]
		private ShuttleRoomSessionNamePad _sessionNamePad;

		[SerializeField]
		private TMP_Text _textOperation;

		[SerializeField]
		private TMP_Text _launchButtonText;

		[SerializeField]
		private GameObject[] _createServerButtonVisuals;

		[SerializeField]
		private GameObject[] _joinAsPlayerButtonVisuals;

		[SerializeField]
		private string _simulatedSessionName;

		private readonly Cooldown _countdownCd;

		private Action _countDownCompleteAction;

		private bool _executeCountdown;

		private bool _executeCountdownOnLaunchButton;

		private int _countDownElapsed;

		private int _countDownDuration;

		private string _countdownText;

		private IMessageSubscriber _messageSubscriber;

		private LaunchMode _launchMode;

		private bool _isRequestingServer;

		private CancellationTokenSource _messageTokenSource;

		private ServerSessionInfo _launchSessionInfo;

		private CancellationTokenSource _requestServerSessionInfoCancellationTokenSource;

		private WaitingMessage _waitingMessage;

		private bool _hasWaitingMessage;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		private void ConnectionManager_OnConnChanged(ConnectionManager.Status status, ShutdownReason arg2)
		{
		}

		private void CancelRequestedServerSessionInfoToken()
		{
		}

		private void DisposeMessageTokenSource()
		{
		}

		private void HandleCustomGameRoomNameChanged()
		{
		}

		private void UpdateConsoleTextsCustomGame()
		{
		}

		private void HandleCustomGameBtnSwitchRegionPressed()
		{
		}

		private void HandleCustomGameLaunchObserverButtonChanged()
		{
		}

		private void HandleCustomGameLaunchButtonChanged()
		{
		}

		private void TryLaunchToArena(LaunchMode launchMode)
		{
		}

		private void HandleShuttleToArenaResult(bool completedSuccessfully, ShutdownReason shutdownReason)
		{
		}

		private void SetupCountdown(int duration, string text, bool updateLaunchButtonText, Action completeAction)
		{
		}

		private void TryCancelTeleportCountdown()
		{
		}

		private int HandleMatchmakingStateChanged(object _)
		{
			return 0;
		}

		private void HandleCustomArenaServerRequestSuccess(string serverId)
		{
		}

		private void HandleCustomArenaServerRequestFail(RequestServerResultError requestServerResultError)
		{
		}

		private void HandleRequestServerSessionFail(HttpStatusCode error)
		{
		}

		[AsyncStateMachine(typeof(_003CShowMessage_003Ed__47))]
		private Task ShowMessage(string message, string launchButtonText)
		{
			return null;
		}

		private void SetMachineTexts(string text, bool isWaitingMessage, [CanBeNull] string launchButtonText = null)
		{
		}

		private void ToggleLaunchButtonVisuals(bool showCreateServer)
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		[UsedImplicitly]
		private void SimulateButtonPressed()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		[UsedImplicitly]
		private void SimulateButtonPressedAsObserver()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		[UsedImplicitly]
		private void SimulateButtonPressedNoServerCheck()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		[UsedImplicitly]
		private void SimulateObserverButtonPressedNoServerCheck()
		{
		}
	}
}
