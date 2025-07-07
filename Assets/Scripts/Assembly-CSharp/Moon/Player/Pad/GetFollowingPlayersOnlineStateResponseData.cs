using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace Moon.Player.Pad
{
	[Serializable]
	[Preserve]
	public class GetFollowingPlayersOnlineStateResponseData : SocialResponseBaseData
	{
		public List<FollowingPlayerOnlineState> FollowingPlayersOnlineStateList;
	}
}
