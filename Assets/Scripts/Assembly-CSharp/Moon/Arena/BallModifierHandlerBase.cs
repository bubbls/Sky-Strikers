using Fusion;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(0)]
	public abstract class BallModifierHandlerBase : NetworkBehaviour
	{
		private SqueezeBallOnHit _squeezeBallOnHit;

		private static Changed<BallModifierHandlerBase> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<BallModifierHandlerBase> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<BallModifierHandlerBase> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected MBall CurrentMBall { get; private set; }

		protected BallTrailFxController BallTrailFxController { get; private set; }

		public void SetBallModifer(MBall mBall)
		{
		}

		public void HandleDespawned()
		{
		}

		public void ToggleModifier(bool enable)
		{
		}

		public virtual void HandleFixedUpdateNetwork()
		{
		}

		public virtual void HandleRender()
		{
		}

		protected virtual void HandleOnRegisterEvents()
		{
		}

		protected virtual void HandleOnSetup()
		{
		}

		protected virtual void HandleOnDespawned()
		{
		}

		protected virtual void HandleOnUnregisterEvents()
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
