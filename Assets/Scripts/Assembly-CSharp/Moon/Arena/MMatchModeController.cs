using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(1)]
	public abstract class MMatchModeController : NetworkBehaviour
	{
		[SerializeField]
		[DefaultForProperty("ElapsedTime", 0, 1)]
		private float _ElapsedTime;

		private static Changed<MMatchModeController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MMatchModeController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MMatchModeController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 1)]
		public float ElapsedTime
		{
			get
			{
				return 0f;
			}
			protected set
			{
			}
		}

		public virtual void SyncToSharedData()
		{
		}

		public abstract void ExecutePrepareState(MFSM.Phase phase);

		public abstract void ExecuteMatchState(MFSM.Phase phase);

		public abstract bool IsMatchEnd();

		protected void UpdateElapsedTime()
		{
		}

		protected virtual void RaiseOnTimeChanged()
		{
		}

		public abstract void ExecuteMatchEndState(MFSM.Phase phase);

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
