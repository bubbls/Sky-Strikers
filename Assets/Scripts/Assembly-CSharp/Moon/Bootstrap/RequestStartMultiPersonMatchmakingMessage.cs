using System;
using System.Collections.Generic;
using Moon.Arena;

namespace Moon.Bootstrap
{
	public class RequestStartMultiPersonMatchmakingMessage
	{
		public string[] PlayersPlayFabIds;

		public FieldType FieldType;

		public string RoomName;

		public int MMRScore;

		public List<string> PreferredRegions;

		public List<string> PairPlayFabIdList;

		public Action<ClientSharedData.Error> ConnectionAttemptComplete;
	}
}
