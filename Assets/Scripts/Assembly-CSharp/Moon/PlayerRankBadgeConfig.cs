using System.Collections.Generic;
using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(fileName = "PlayerRankBadgeConfig", menuName = "Moon/Rank/Create PlayerRankBadgeConfig")]
	public class PlayerRankBadgeConfig : SingleScriptableObject<PlayerRankBadgeConfig, DefaultResourcePathProvider<PlayerRankBadgeConfig>>
	{
		[SerializeField]
		private List<PlayerRankBadgeData> _rankBadgeDataList;

		public Sprite GetRankBadgeAsset(string rankBadgeLevel)
		{
			return null;
		}
	}
}
