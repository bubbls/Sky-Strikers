using System.Collections.Generic;
using Chamber8.Framework.Common;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Arena
{
	[CreateAssetMenu(fileName = "TeleportSettings", menuName = "Chamber8/Arena/Create TeleportSettings")]
	public class TeleportSettings : SingleScriptableObject<TeleportSettings, DefaultResourcePathProvider<TeleportSettings>>
	{
		public List<Location> TeleportableLocations;
	}
}
