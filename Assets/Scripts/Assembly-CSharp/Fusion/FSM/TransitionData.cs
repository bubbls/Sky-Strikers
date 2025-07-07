namespace Fusion.FSM
{
	public struct TransitionData<TState> where TState : IState
	{
		public readonly TState TargetState;

		public readonly Transition<TState> Transition;

		public readonly bool IsForced;

		public TransitionData(TState targetState, Transition<TState> transition, bool isForced = false)
		{
			TargetState = default(TState);
			Transition = null;
			IsForced = false;
		}
	}
}
