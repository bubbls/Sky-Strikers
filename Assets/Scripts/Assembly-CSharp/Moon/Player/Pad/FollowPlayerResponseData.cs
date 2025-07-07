using System;
using UnityEngine.Scripting;

namespace Moon.Player.Pad
{
	[Serializable]
	[Preserve]
	public class FollowPlayerResponseData : SocialResponseBaseData
	{
		public string ErrorMessage;
	}
}
