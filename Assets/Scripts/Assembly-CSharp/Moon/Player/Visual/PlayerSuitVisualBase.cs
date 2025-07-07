using Moon.Arena;

namespace Moon.Player.Visual
{
	public abstract class PlayerSuitVisualBase : PlayerVisualBase
	{
		public SuitVisualTheme SuitVisualTheme { get; private set; }

		public override int ThemeInt => 0;

		protected override void SetTheme(int theme)
		{
		}

		protected override PlayerMaterial GetPlayerMaterial(TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		public virtual void HandleOnHoldingWeaponStateChanged(bool isWeaponOnLeftHand, bool isWeaponOnRightHand)
		{
		}
	}
}
