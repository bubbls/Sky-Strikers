using System;

namespace Moon.MultiPlay
{
	[Serializable]
	public class RankedPlayerSessionData
	{
		public string PlayFabId;

		public string SessionId;

		public string PhotonRegion;

		public string PlayFabRegion;

		public bool IsInParty;

		public string TeamId;

		public int SuitClass;
	}
}
