using System;
using UnityEngine.Scripting;

namespace Moon.Player.Pad
{
	[Serializable]
	[Preserve]
	public class TryRecordFollowerRequestData : SocialRequestBaseData
	{
		public string FollowerPlayerName;
	}
}
