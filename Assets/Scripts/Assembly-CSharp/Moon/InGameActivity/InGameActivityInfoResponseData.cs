using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace Moon.InGameActivity
{
	[Serializable]
	[Preserve]
	public class InGameActivityInfoResponseData
	{
		public int Amount;

		public double RemainingTime;

		public InGameActivityPlayerInfoData PlayerActivityInfo;

		public List<InGameActivityPlayerEntryData> TopInGameActivityPlayerEntries;

		public InGameActivityRemoteConfig RemoteConfig;
	}
}
