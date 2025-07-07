using Moon.Player.Visual;

namespace Moon.Commands
{
	public class UpdateAmmoStatusVisual : PlayerCommand
	{
		private readonly WeaponType _weaponType;

		private readonly MAmmoBox.Status _status;

		public UpdateAmmoStatusVisual(WeaponType weaponType, MAmmoBox.Status status)
		{
		}

		protected override void Execute(PlayerInfoVisualsHandler playerInfoVisualsHandler)
		{
		}
	}
}
