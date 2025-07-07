using System;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(133)]
	public class MHubVoteMachine : NetworkBehaviour
	{
		[DefaultForProperty("GameSettingsOptionOne", 0, 31)]
		private HubGameSettings _GameSettingsOptionOne;

		[DefaultForProperty("GameSettingsOptionTwo", 31, 31)]
		private HubGameSettings _GameSettingsOptionTwo;

		[SerializeField]
		[DefaultForProperty("PlayerVotes", 62, 71)]
		private SerializableDictionary<PlayerRef, int> _PlayerVotes;

		private VoteMachineUI _voteMachineUI;

		private bool _isUIInitialized;

		private bool _isSpawned;

		private bool _canCheckForMinVotes;

		private HubGameSettings _previousVotedGameSettings;

		private int _totalOptionOneVotes;

		private int _totalOptionTwoVotes;

		private bool _didOptionOneWinLastVote;

		[SerializeField]
		[Header("Editor Only")]
		[Space(7f)]
		private bool _allowSingleVote;

		private static Changed<MHubVoteMachine> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubVoteMachine> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubVoteMachine> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 31)]
		private HubGameSettings GameSettingsOptionOne
		{
			get
			{
				return default(HubGameSettings);
			}
			set
			{
			}
		}

		[NetworkedWeaved(31, 31)]
		[Networked]
		private HubGameSettings GameSettingsOptionTwo
		{
			get
			{
				return default(HubGameSettings);
			}
			set
			{
			}
		}

		[NetworkedWeaved(62, 71)]
		[Capacity(10)]
		[Networked]
		public NetworkDictionary<PlayerRef, int> PlayerVotes => default(NetworkDictionary<PlayerRef, int>);

		public event Action OnMinVotesReceived
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

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void OnDestroy()
		{
		}

		private void TryLoadUI()
		{
		}

		private void OptionOneButton_OnPressed()
		{
		}

		private void OptionTwoButton_OnPressed()
		{
		}

		private void ConnectionManager_OnPlayerLeftEvent(PlayerRef playerRef)
		{
		}

		public void PrepareNewVotingOptions()
		{
		}

		public void StartCheckingForMinVotes()
		{
		}

		public void StopCheckingForMinVotes()
		{
		}

		public void ClearVotes()
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_UpdateVoteUI(int optionOneVotes, int optionTwoVotes)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true, Channel = RpcChannel.Reliable, TickAligned = false)]
		private void Rpc_RegisterVote(int option, PlayerRef voter)
		{
		}

		private void CheckIfHasMinVotes(int optionOneVotes, int optionTwoVotes)
		{
		}

		private void UpdateVoteCount(int optionOneVotes, int optionTwoVotes)
		{
		}

		private void TallyVotes(out int optionOneVotes, out int optionTwoVotes)
		{
			optionOneVotes = default(int);
			optionTwoVotes = default(int);
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_RefreshVoteUI()
		{
		}

		public void RefreshVoteUI()
		{
		}

		public void UpdateVoteTimeText(int time)
		{
		}

		public HubGameSettings SelectWinningOption()
		{
			return default(HubGameSettings);
		}

		public void LogVoteResults(string matchId)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_UpdateVoteUI_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 7, 1)]
		[Preserve]
		protected unsafe static void Rpc_RegisterVote_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(3, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_RefreshVoteUI_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
