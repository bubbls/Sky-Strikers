using Fusion;
using Moon.Arena;

namespace Moon.Player.Ability.Prime
{
	[NetworkBehaviourWeaved(20)]
	public class MPrimeMissile : MMissile
	{
		private static Changed<MPrimeMissile> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPrimeMissile> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPrimeMissile> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override MissileConfig GetMissileConfig()
		{
			return null;
		}

		protected override ExplosionConfiguration GetExplosionConfiguration()
		{
			return null;
		}

		protected override MissileVisual LoadMissileVisual()
		{
			return null;
		}

		protected override void LoadExplosionFx(in LocalExplosion explosion, TeamNo teamNo)
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
