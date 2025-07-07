using DP.Takeaway.VisualScripting;
using Fusion;
using TMPro;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(13)]
	[RequireComponent(typeof(CustomEventHandler))]
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Host | SimulationModes.Client))]
	public class MGameSettingsConsole : NetworkBehaviour
	{
		[SerializeField]
		private TMP_Text _textTime;

		[SerializeField]
		private TMP_Text _textOvertimeDuration;

		[SerializeField]
		private TMP_Text _textOvertimeTitle;

		[SerializeField]
		private TMP_Text _textOvertimeState;

		[SerializeField]
		private TMP_Text _textMaxGoal;

		[SerializeField]
		private GameObject _overtimeButtons;

		[SerializeField]
		private GameObject _overtimeToggle;

		[SerializeField]
		private GameObject _btnMusic;

		[SerializeField]
		private GameObject _btnSnapTurn;

		[SerializeField]
		private GameObject _btnSwitcheroo;

		[SerializeField]
		private GameObject _btnSpeedLines;

		[SerializeField]
		private TMP_Text _textMasterClient;

		[SerializeField]
		private GameObject[] _buttons;

		[SerializeField]
		private GameObject[] _masterClientBanners;

		[SerializeField]
		private GameObject[] _nonMasterClientBanners;

		[SerializeField]
		private GameObject _timedModePanel;

		[SerializeField]
		private GameObject _maxGoalsModePanel;

		[DefaultForProperty("GameSettings", 0, 13)]
		private GameSettings _GameSettings;

		private CustomEventHandler _customEventHandler;

		private bool _wasMasterClient;

		private static Changed<MGameSettingsConsole> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGameSettingsConsole> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGameSettingsConsole> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "OnGameModeChanged")]
		[NetworkedWeaved(0, 13)]
		private GameSettings GameSettings
		{
			get
			{
				return default(GameSettings);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public override void Spawned()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void UpdateToggles()
		{
		}

		private void UpdateVisual()
		{
		}

		private void ShowButtonsOnMasterClient()
		{
		}

		[Preserve]
		private static void OnGameModeChanged(Changed<MGameSettingsConsole> changed)
		{
		}

		private void TryStartMatch()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void RPC_ChangeMode(Mode gameMode, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		private static GameSettings VerifyTimedMode(GameSettings gameSettings)
		{
			return default(GameSettings);
		}

		private bool IsInvokedByGameMasterOrInSingleMode(RpcInfo rpcInfo)
		{
			return false;
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void RPC_ChangeTime(bool incr, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void RPC_ToggleOvertime(bool isOn, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void RPC_ChangeOvertime(bool incr, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void RPC_ChangeMaxGoal(bool incr, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void RPC_StartMatch(RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		private void HandleValueChanged(GameObject toggle)
		{
		}

		private void HandleButtonPressed(string btnName)
		{
		}

		private void HandleToggleChanged(GameObject toggle)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 7, 1)]
		[Preserve]
		protected unsafe static void RPC_ChangeMode_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 7, 1)]
		[Preserve]
		protected unsafe static void RPC_ChangeTime_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(3, 7, 1)]
		[Preserve]
		protected unsafe static void RPC_ToggleOvertime_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(4, 7, 1)]
		[Preserve]
		protected unsafe static void RPC_ChangeOvertime_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(5, 7, 1)]
		[Preserve]
		protected unsafe static void RPC_ChangeMaxGoal_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(6, 7, 1)]
		protected unsafe static void RPC_StartMatch_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
