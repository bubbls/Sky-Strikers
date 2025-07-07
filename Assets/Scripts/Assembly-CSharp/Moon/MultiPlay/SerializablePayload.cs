namespace Moon.MultiPlay
{
	public abstract class SerializablePayload
	{
		public byte[] Serialize()
		{
			return null;
		}

		public static T DeserializeWeak<T>(byte[] data) where T : SerializablePayload
		{
			return null;
		}
	}
}
