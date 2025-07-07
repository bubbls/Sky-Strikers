namespace Fusion.FSM
{
	public interface IOwnedState<TState> where TState : class, IState
	{
		StateMachine<TState> Machine { get; set; }

		void AddTransition(TransitionData<TState> transition);
	}
}
