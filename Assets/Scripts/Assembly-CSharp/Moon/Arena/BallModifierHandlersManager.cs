using System;
using DP.Takeaway.Runtime;
using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	[SimulationBehaviour(Stages = SimulationStages.Forward)]
	[NetworkBehaviourWeaved(0)]
	public class BallModifierHandlersManager : NetworkBehaviour
	{
		[Serializable]
		private class BallModifierHandlers : DP.Takeaway.Runtime.SerializableDictionary<BallModifier, BallModifierHandlerBase>
		{
		}

		[Space(5f)]
		[SerializeField]
		private BallModifierHandlers _ballModifierHandlers;

		private BallModifierHandlerBase _activeBallModifierHandler;

		private bool _hasActiveBallModifierHandler;

		private MBall _mBall;

		private static Changed<BallModifierHandlersManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<BallModifierHandlersManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<BallModifierHandlersManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public void SetBallModifier(MBall mBall, BallModifier ballModifier)
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		public override void Render()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
