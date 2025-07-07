using UnityEngine.Scripting;

namespace Moon.Mission
{
	[Preserve]
	public class MissionRecord
	{
		public string BundleId;

		public string Name;

		public string Description;

		public int StatValueCondition;

		public int Progress;

		public string Status;

		public RewardItem RewardItem;

		public MissionTable MissionTable;
	}
}
