using Moon.Player.Visual;

namespace Moon.Commands
{
	public class ChangeAmmo : PlayerCommand, IPowerUpResult
	{
		public enum ChangeType
		{
			Set = 0,
			Incr = 1
		}

		private readonly WeaponType _weaponType;

		private readonly int _amount;

		private readonly ChangeType _changeType;

		public bool Success { get; private set; }

		public int Diff { get; private set; }

		public ChangeAmmo(WeaponType weaponType, int amount, ChangeType changeType)
		{
		}

		protected override void Execute(MAmmoBox ammoBox)
		{
		}

		protected override void Execute(PlayerInfoVisualsHandler playerInfoVisualsHandler)
		{
		}
	}
}
