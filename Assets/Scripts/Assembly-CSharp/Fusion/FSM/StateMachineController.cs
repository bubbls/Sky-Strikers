using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Fusion.FSM
{
	[DisallowMultipleComponent]
	[NetworkBehaviourWeaved(0)]
	public sealed class StateMachineController : NetworkBehaviour, IBeforeAllTicks, IAfterTick
	{
		[Header("DEBUG")]
		[SerializeField]
		private bool _enableLogging;

		private List<IStateMachine> _stateMachines;

		private List<IState> _statePool;

		private bool _stateMachinesCollected;

		private bool _manualUpdate;

		private static Changed<StateMachineController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<StateMachineController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<StateMachineController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public bool EnableLogging
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<IStateMachine> StateMachines => null;

		public override int? DynamicWordCount => null;

		public void SetManualUpdate(bool manualUpdate)
		{
		}

		public void ManualFixedUpdate()
		{
		}

		public void ManualRender()
		{
		}

		public override void Spawned()
		{
		}

		public override void Render()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		void IBeforeAllTicks.BeforeAllTicks(bool resimulation, int tickCount)
		{
		}

		void IAfterTick.AfterTick()
		{
		}

		private void FixedUpdateInternal()
		{
		}

		private void RenderInternal()
		{
		}

		private void CollectStateMachines()
		{
		}

		private int GetNetworkDataWordCount()
		{
			return 0;
		}

		private void ReadNetworkData()
		{
		}

		private void WriteNetworkData()
		{
		}

		private bool Interpolate()
		{
			return false;
		}

		[Conditional("DEBUG")]
		private void CheckCollectedMachines(IStateMachineOwner owner, List<IStateMachine> machines)
		{
		}

		[Conditional("DEBUG")]
		private void CheckDuplicateStates(string stateMachineName, IState[] states)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
