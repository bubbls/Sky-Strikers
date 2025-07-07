using UnityEngine;

namespace Moon.Player.Visual
{
	public abstract class ChampionWeaponFx : MonoBehaviour
	{
		protected bool FxEnabled { get; private set; }

		public void Initialize()
		{
		}

		protected abstract void InitializeInternal();

		public void Dispose()
		{
		}

		protected abstract void DisposeInternal();

		public void EnableFx()
		{
		}

		protected abstract void EnableFxInternal();

		public void DisableFx()
		{
		}

		protected abstract void DisableFxInternal();
	}
}
