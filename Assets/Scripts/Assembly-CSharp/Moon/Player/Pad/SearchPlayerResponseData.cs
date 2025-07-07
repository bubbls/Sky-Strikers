using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace Moon.Player.Pad
{
	[Serializable]
	[Preserve]
	public class SearchPlayerResponseData
	{
		public List<SearchPlayerEntry> SearchPlayerEntries;
	}
}
