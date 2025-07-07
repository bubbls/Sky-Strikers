using Fusion;

namespace Moon
{
	public class PlayerAmmoStatusChangedMessage
	{
		public PlayerRef InputAuthority;

		public WeaponType WeaponType;

		public MAmmoBox.Status Status;
	}
}
