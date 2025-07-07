using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Moon.MultiPlay
{
	[Serializable]
	[UsedImplicitly]
	public class RankedPlayerSessionDataContainer
	{
		public List<RankedPlayerSessionData> Players;

		public bool UpdateExpiryTime;
	}
}
