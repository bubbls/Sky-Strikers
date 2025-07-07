using System.Collections.Generic;
using UnityEngine.Scripting;

namespace Moon.Mission
{
	[Preserve]
	public class MissionRecordList
	{
		public string DueTime;

		public bool IsNew;

		public List<MissionRecord> Missions;
	}
}
