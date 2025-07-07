using System;

namespace Moon.MultiPlay
{
	[Serializable]
	public class MMRCalculateResultData
	{
		public int CurrentMinMMR;

		public int CurrentMaxMMR;

		public int NextMaxMMR;

		public int NewMMR;

		public int ChangeDifference;
	}
}
