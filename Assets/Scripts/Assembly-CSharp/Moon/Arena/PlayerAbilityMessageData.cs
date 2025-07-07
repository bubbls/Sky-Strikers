using Fusion;

namespace Moon.Arena
{
	public class PlayerAbilityMessageData : IMessageData
	{
		public PlayerRef Behitter { get; }

		public PlayerRef Hitter { get; }

		public PlayerSuitClass SuitClass { get; }

		public PlayerAbilityMessageData(PlayerRef behitter, PlayerRef hitter, PlayerSuitClass suitClass)
		{
		}
	}
}
