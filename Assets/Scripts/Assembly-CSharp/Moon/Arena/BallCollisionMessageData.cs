namespace Moon.Arena
{
	public class BallCollisionMessageData : IMessageData
	{
		public CollisionInfo CollisionInfo { get; private set; }

		public IMessageData Reset(CollisionInfo collisionInfo)
		{
			return null;
		}
	}
}
