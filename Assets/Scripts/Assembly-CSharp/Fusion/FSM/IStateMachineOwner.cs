using System.Collections.Generic;

namespace Fusion.FSM
{
	public interface IStateMachineOwner
	{
		void CollectStateMachines(List<IStateMachine> stateMachines);
	}
}
