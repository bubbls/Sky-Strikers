using Moon.MultiPlay;

namespace Moon.Arena
{
	public class BallHittableInfoMessageData : IMessageData
	{
		public MBall Ball { get; private set; }

		public BallHitData BallHitData { get; private set; }

		public BallHittableInfoMessageData Reset(MBall ball, BallHitData ballHitData)
		{
			return null;
		}
	}
}
