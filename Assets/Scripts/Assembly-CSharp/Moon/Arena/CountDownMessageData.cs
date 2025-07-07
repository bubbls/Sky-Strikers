namespace Moon.Arena
{
	public class CountDownMessageData : IMessageData
	{
		public float RemainingTime { get; private set; }

		public CountDownMessageData Reset(float remainingTime)
		{
			return null;
		}
	}
}
