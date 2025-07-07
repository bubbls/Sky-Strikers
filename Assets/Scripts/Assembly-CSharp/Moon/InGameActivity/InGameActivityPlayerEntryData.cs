using System;
using UnityEngine.Scripting;

namespace Moon.InGameActivity
{
	[Serializable]
	[Preserve]
	public class InGameActivityPlayerEntryData
	{
		public string PlayerDisplayName;

		public int ActivityPoint;

		public int Position;
	}
}
