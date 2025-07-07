using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Fusion.FSM
{
	public abstract class State : State<State>
	{
		protected State()
			: base((string)null, 0)
		{
		}
	}
	public abstract class State<TState> : IState, IOwnedState<TState> where TState : State<TState>
	{
		public bool CheckPriorityOnExit;

		private List<TransitionData<TState>> _transitions;

		public int StateId { get; set; }

		public StateMachine<TState> Machine { get; set; }

		public string Name { get; set; }

		public int Priority { get; set; }

		string IState.Name => null;

		IStateMachine[] IState.ChildMachines
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected State(string name, int priority = 0)
		{
		}

		protected State()
		{
		}

		public void AddTransition(TransitionData<TState> transition)
		{
		}

		protected virtual void OnInitialize()
		{
		}

		protected virtual void OnDeinitialize(bool hasState)
		{
		}

		protected virtual bool CanEnterState()
		{
			return false;
		}

		protected virtual bool CanExitState(IState nextState)
		{
			return false;
		}

		protected virtual void OnEnterState()
		{
		}

		protected virtual void OnFixedUpdate()
		{
		}

		protected virtual void OnExitState()
		{
		}

		protected virtual void OnEnterStateRender()
		{
		}

		protected virtual void OnRender()
		{
		}

		protected virtual void OnExitStateRender()
		{
		}

		protected virtual void CollectChildStateMachines(List<IStateMachine> stateMachines)
		{
		}

		protected virtual int GetNetworkDataWordCount()
		{
			return 0;
		}

		protected unsafe virtual void ReadNetworkData(int* ptr)
		{
		}

		protected unsafe virtual void WriteNetworkData(int* ptr)
		{
		}

		void IState.OnFixedUpdate()
		{
		}

		bool IState.CanExitState(IState nextState, bool isExplicitDeactivation)
		{
			return false;
		}

		void IState.Initialize()
		{
		}

		void IState.Deinitialize(bool hasState)
		{
		}

		bool IState.CanEnterState()
		{
			return false;
		}

		void IState.OnEnterState()
		{
		}

		void IState.OnExitState()
		{
		}

		void IState.OnEnterStateRender()
		{
		}

		void IState.OnRender()
		{
		}

		void IState.OnExitStateRender()
		{
		}

		void IState.CollectChildStateMachines(List<IStateMachine> stateMachines)
		{
		}

		int IState.GetWordCount()
		{
			return 0;
		}

		unsafe void IState.Read(int* ptr)
		{
		}

		unsafe void IState.Write(int* ptr)
		{
		}

		private bool TryTransition(ref TransitionData<TState> transition)
		{
			return false;
		}
	}
}
