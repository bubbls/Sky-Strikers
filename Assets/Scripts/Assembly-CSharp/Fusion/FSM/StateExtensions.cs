using System;

namespace Fusion.FSM
{
	public static class StateExtensions
	{
		public static void AddTransition<TState>(this IOwnedState<TState> state, TState targetState, Transition<TState> transition, bool forced = false) where TState : class, IState
		{
		}

		public static void AddTransition<TState>(this IOwnedState<TState> state, TState targetState, Func<bool> transition, bool isForced = false) where TState : class, IState
		{
		}
	}
}
