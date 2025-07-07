using Moon.Player.Visual;

namespace Moon
{
	public abstract class PlayerAmmoIndicator : PlayerInfoVisual
	{
		public abstract void SetAmmo(int targetAmount);
	}
}
