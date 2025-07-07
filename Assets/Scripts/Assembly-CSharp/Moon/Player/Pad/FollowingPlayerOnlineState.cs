using System;
using UnityEngine.Scripting;

namespace Moon.Player.Pad
{
	[Serializable]
	[Preserve]
	public class FollowingPlayerOnlineState
	{
		public string PlayFabId;

		public bool IsOnline;

		public string FieldType;

		public string SessionCode;

		public string SocialPrivacyState;
	}
}
