using System;
using DP.Takeaway.Runtime;

namespace Moon.Player.Visual
{
	[Serializable]
	public class CustomAttachPointAdjustments : SerializableDictionary<PlayerVisualAttachPointType, AttachPointAdjustmentCollection>
	{
		public void TryAdjustTransforms(PlayerVisualAttachPointType currentAttachPointType)
		{
		}
	}
}
