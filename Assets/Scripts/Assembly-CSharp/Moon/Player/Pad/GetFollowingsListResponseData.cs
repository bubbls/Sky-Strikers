using System;
using System.Collections.Generic;
using PlayFab.ClientModels;
using UnityEngine.Scripting;

namespace Moon.Player.Pad
{
	[Serializable]
	[Preserve]
	public class GetFollowingsListResponseData : SocialResponseBaseData
	{
		public List<FriendInfo> FollowingPlayersList;
	}
}
