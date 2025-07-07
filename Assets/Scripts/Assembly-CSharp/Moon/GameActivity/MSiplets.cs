using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using Fusion;
using UnityEngine;

namespace Moon.GameActivity
{
	[NetworkBehaviourWeaved(5)]
	public class MSiplets : MPowerUp
	{
		[SerializeField]
		private int _count;

		[SerializeField]
		private GameObject _visual;

		[SerializeField]
		private Transform[] _emitPositions;

		[SerializeField]
		private SoundInfo _sfxMelt;

		private static Changed<MSiplets> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MSiplets> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MSiplets> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void Spawned()
		{
		}

		protected override void ToggleVisuals(bool show)
		{
		}

		protected override ICommand GetPowerUpCommand(MHitter hitter, out int amount)
		{
			amount = default(int);
			return null;
		}

		protected override void UpdateVisual(bool wasGenerated)
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
