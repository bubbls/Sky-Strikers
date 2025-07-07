using System;
using System.Collections.Generic;

namespace Moon.Bootstrap
{
	[Serializable]
	public class MatchmakingPlayerAttributesDataObject
	{
		public List<Latency> Latencies;

		public string RoomName;

		public string FieldType;

		public bool IsInParty;
	}
}
