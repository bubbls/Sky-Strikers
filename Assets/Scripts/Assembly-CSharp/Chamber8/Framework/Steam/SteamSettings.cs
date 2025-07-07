using Chamber8.Framework.Common;
using UnityEngine;

namespace Chamber8.Framework.Steam
{
	[CreateAssetMenu(fileName = "SteamSettings", menuName = "Chamber8/Steam/Create SteamSettings")]
	public class SteamSettings : SingleScriptableObject<SteamSettings, DefaultResourcePathProvider<SteamSettings>>
	{
		public uint AppId;
	}
}
