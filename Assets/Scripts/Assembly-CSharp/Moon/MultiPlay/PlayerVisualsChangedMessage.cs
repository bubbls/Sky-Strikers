namespace Moon.MultiPlay
{
	public class PlayerVisualsChangedMessage
	{
		public bool SuitChanged { get; }

		public bool SuitWeaponChanged { get; }

		public bool AvatarChanged { get; }

		public PlayerVisualsConfig CurrentVisualsConfig { get; }

		public PlayerVisualsChangedMessage(PlayerVisualsConfig currentVisualsConfig, bool suitChanged, bool suitWeaponChanged, bool avatarChanged)
		{
		}
	}
}
