using System.Diagnostics;

namespace Fusion.FSM
{
	public class StateMachine<TState> : IStateMachine where TState : class, IState
	{
		private readonly TState[] _states;

		private readonly int _stateCount;

		private readonly int _defaultStateId;

		private int _lastRenderStateId;

		private int _lastRenderStateChangeTick;

		private float _interpolationTick;

		private StateMachineController _controller;

		private int _activeStateId;

		private int _previousStateId;

		private int _stateChangeTick;

		private int _bitState;

		private int _wordCount;

		private bool _statesContainData;

		private bool _hasChildMachines;

		public string Name { get; private set; }

		public NetworkRunner Runner { get; private set; }

		public bool? EnableLogging { get; set; }

		public TState[] States => null;

		public int ActiveStateId => 0;

		public int PreviousStateId => 0;

		public int StateChangeTick => 0;

		public float StateTime => 0f;

		public int StateTicks => 0;

		public TState ActiveState => null;

		public TState PreviousState => null;

		public bool HasStarted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsPaused
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		IState[] IStateMachine.States => null;

		IState IStateMachine.ActiveState => null;

		IState IStateMachine.PreviousState => null;

		int IStateMachine.WordCount => 0;

		public StateMachine(string name, params TState[] states)
		{
		}

		public bool TryActivateState(int stateId, bool allowReset = false)
		{
			return false;
		}

		public bool ForceActivateState(int stateId, bool allowReset = false)
		{
			return false;
		}

		public bool TryDeactivateState(int stateId)
		{
			return false;
		}

		public bool ForceDeactivateState(int stateId)
		{
			return false;
		}

		public bool TryToggleState(int stateId, bool value)
		{
			return false;
		}

		public void ForceToggleState(int stateId, bool value)
		{
		}

		public bool HasState(TState state)
		{
			return false;
		}

		public TState GetState(int stateId)
		{
			return null;
		}

		public T GetState<T>() where T : TState
		{
			return default(T);
		}

		public void Reset()
		{
		}

		void IStateMachine.Initialize(StateMachineController controller, NetworkRunner runner)
		{
		}

		void IStateMachine.FixedUpdateNetwork()
		{
		}

		void IStateMachine.Render()
		{
		}

		void IStateMachine.Deinitialize(bool hasState)
		{
		}

		private bool TryActivateState(int stateId, bool allowReset, bool isExplicitDeactivation)
		{
			return false;
		}

		private void ChangeState(int stateId)
		{
		}

		private int GetStateTicks()
		{
			return 0;
		}

		private float GetStateTime()
		{
			return 0f;
		}

		[Conditional("DEBUG")]
		private void LogStateChange()
		{
		}

		[Conditional("DEBUG")]
		private void LogRenderStateChange()
		{
		}

		unsafe void IStateMachine.Read(int* ptr)
		{
		}

		unsafe void IStateMachine.Write(int* ptr)
		{
		}

		void IStateMachine.Interpolate(InterpolationData interpolationData)
		{
		}

		protected virtual int GetUserDataWordCount()
		{
			return 0;
		}

		protected unsafe virtual void ReadUserData(int* ptr)
		{
		}

		protected unsafe virtual void WriteUserData(int* ptr)
		{
		}

		protected virtual void InterpolateUserData(InterpolationData interpolationData)
		{
		}

		private void CollectChildMachines()
		{
		}

		private int GetWordCount()
		{
			return 0;
		}
	}
}
