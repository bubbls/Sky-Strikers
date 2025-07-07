using Moon.MultiPlay;

namespace Moon.Arena
{
	public class BallHitMessageData : IMessageData
	{
		public BallHitData BallHitData { get; }

		public BallHitMessageData(BallHitData ballHitData)
		{
		}
	}
}
