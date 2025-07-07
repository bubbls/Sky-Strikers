using Fusion;
using Moon.Arena;

namespace Moon
{
	public class PlayerEnergyCollectedMessage
	{
		public PlayerRef collector;

		public int amount;

		public int diff;

		public TeamNo teamNo;
	}
}
