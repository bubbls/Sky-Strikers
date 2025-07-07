using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Fusion.FSM
{
	[NetworkBehaviourWeaved(0)]
	public abstract class StateBehaviour : StateBehaviour<StateBehaviour>
	{
		private static Changed<StateBehaviour> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<StateBehaviour> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<StateBehaviour> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
	[NetworkBehaviourWeaved(0)]
	public abstract class StateBehaviour<TState> : NetworkBehaviour, IState, IOwnedState<TState> where TState : StateBehaviour<TState>
	{
		[SerializeField]
		private int _priority;

		[SerializeField]
		private bool _checkPriorityOnExit;

		private List<TransitionData<TState>> _transitions;

		private static Changed<StateBehaviour<>> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<StateBehaviour<>> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<StateBehaviour<>> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public int StateId { get; set; }

		public StateMachine<TState> Machine { get; set; }

		public virtual string Name => null;

		public int Priority => 0;

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

		protected virtual bool CanExitState(TState nextState)
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

		protected virtual void OnCollectChildStateMachines(List<IStateMachine> stateMachines)
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

		public sealed override void FixedUpdateNetwork()
		{
		}

		public sealed override void Render()
		{
		}

		private bool TryTransition(ref TransitionData<TState> transition)
		{
			return false;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
