using System;
using UnityEngine.Scripting;

namespace Moon.InGameActivity
{
	[Serializable]
	[Preserve]
	public class InGameActivityRemoteConfig
	{
		public string ActivityName;

		public int ThresholdAmount;

		public DateTime ExpireTime;
	}
}
