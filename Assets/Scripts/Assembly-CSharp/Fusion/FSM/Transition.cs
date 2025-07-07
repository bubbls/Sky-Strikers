namespace Fusion.FSM
{
	public delegate bool Transition<in TState>(TState from, TState to) where TState : IState;
}
