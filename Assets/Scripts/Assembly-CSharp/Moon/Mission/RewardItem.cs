using System.Collections.Generic;
using UnityEngine.Scripting;

namespace Moon.Mission
{
	[Preserve]
	public class RewardItem
	{
		public string FriendlyId;

		public int? Amount;

		public string Type;

		public List<RewardItem> Items;
	}
}
