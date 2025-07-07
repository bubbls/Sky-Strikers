namespace Fusion.FSM
{
	public static class StateMachineExtensions
	{
		public static bool TryActivateState(this IStateMachine stateMachine, IState state, bool allowReset = false)
		{
			return false;
		}

		public static bool TryActivateState<T>(this IStateMachine stateMachine, bool allowReset = false) where T : IState
		{
			return false;
		}

		public static bool ForceActivateState(this IStateMachine stateMachine, IState state, bool allowReset = false)
		{
			return false;
		}

		public static bool ForceActivateState<T>(this IStateMachine stateMachine, bool allowReset = false) where T : IState
		{
			return false;
		}

		public static bool TryDeactivateState(this IStateMachine stateMachine, IState state)
		{
			return false;
		}

		public static bool TryDeactivateState<T>(this IStateMachine stateMachine) where T : IState
		{
			return false;
		}

		public static bool ForceDeactivateState(this IStateMachine stateMachine, IState state)
		{
			return false;
		}

		public static bool ForceDeactivateState<T>(this IStateMachine stateMachine) where T : IState
		{
			return false;
		}

		public static bool TryToggleState(this IStateMachine stateMachine, IState state, bool value)
		{
			return false;
		}

		public static bool TryToggleState<T>(this IStateMachine stateMachine, bool value) where T : IState
		{
			return false;
		}

		public static void ForceToggleState(this IStateMachine stateMachine, IState state, bool value)
		{
		}

		public static void ForceToggleState<T>(this IStateMachine stateMachine, bool value) where T : IState
		{
		}

		public static bool HasState(this IStateMachine stateMachine, IState state)
		{
			return false;
		}

		public static IState GetState<T>(this IStateMachine stateMachine) where T : IState
		{
			return null;
		}
	}
}
