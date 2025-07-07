using Moon.Arena;

namespace Moon.Hub
{
	public class ShuttleToNewLocationMessageData : IMessageData
	{
		public FieldType TargetFieldType { get; }

		public ShuttleToNewLocationMessageData(FieldType targetFieldType)
		{
		}
	}
}
