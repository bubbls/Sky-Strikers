using System;
using System.Collections.Generic;
using Moon.Arena;

namespace Moon.Bootstrap
{
	public class RequestJoinMultiPersonTicketMessage
	{
		public string TicketId;

		public FieldType FieldType;

		public string RoomName;

		public int MMRScore;

		public List<string> PreferredRegions;

		public Action<ClientSharedData.Error> JoinAttemptComplete;
	}
}
