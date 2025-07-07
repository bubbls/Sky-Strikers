using Fusion;
using Moon.Arena;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	[NetworkBehaviourWeaved(2)]
	public class MJetstreamExplosion : MExplosion
	{
		[DefaultForProperty("NetworkedSuitWeaponVisualTheme", 1, 1)]
		private SuitWeaponVisualTheme _NetworkedSuitWeaponVisualTheme;

		private SuitWeaponVisualTheme _predictedSuitWeaponVisualTheme;

		private static Changed<MJetstreamExplosion> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MJetstreamExplosion> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MJetstreamExplosion> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(1, 1)]
		private SuitWeaponVisualTheme NetworkedSuitWeaponVisualTheme
		{
			get
			{
				return default(SuitWeaponVisualTheme);
			}
			set
			{
			}
		}

		public SuitWeaponVisualTheme SuitWeaponVisualTheme
		{
			get
			{
				return default(SuitWeaponVisualTheme);
			}
			set
			{
			}
		}

		protected override ExplosionConfiguration GetExplosionConfiguration()
		{
			return null;
		}

		protected override void LoadExplosionFx(in LocalExplosion explosion, TeamNo teamNo)
		{
		}

		protected override LayerMask GetExplosionQueryMask()
		{
			return default(LayerMask);
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
