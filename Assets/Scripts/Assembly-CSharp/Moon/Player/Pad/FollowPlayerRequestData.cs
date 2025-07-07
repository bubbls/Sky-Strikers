using System;
using UnityEngine.Scripting;

namespace Moon.Player.Pad
{
	[Serializable]
	[Preserve]
	public class FollowPlayerRequestData : SocialRequestBaseData
	{
		public string FollowerPlayerName;
	}
}
