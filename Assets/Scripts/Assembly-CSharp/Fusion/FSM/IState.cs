using System.Collections.Generic;

namespace Fusion.FSM
{
	public interface IState
	{
		int StateId { get; set; }

		string Name { get; }

		IStateMachine[] ChildMachines { get; set; }

		void Initialize();

		void Deinitialize(bool hasState);

		bool CanEnterState();

		bool CanExitState(IState nextState, bool isExplicitDeactivation);

		void OnEnterState();

		void OnFixedUpdate();

		void OnExitState();

		void OnEnterStateRender();

		void OnRender();

		void OnExitStateRender();

		internal void CollectChildStateMachines(List<IStateMachine> stateMachines)
		{
		}

		int GetWordCount()
		{
			return 0;
		}

		unsafe void Read(int* ptr)
		{
		}

		unsafe void Write(int* ptr)
		{
		}

		void Interpolate(InterpolationData interpolationData)
		{
		}
	}
}
