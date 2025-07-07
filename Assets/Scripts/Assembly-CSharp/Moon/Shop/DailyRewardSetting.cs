using UnityEngine;

namespace Moon.Shop
{
	[CreateAssetMenu(fileName = "DailyRewardSetting", menuName = "Moon/Shop/Create DailyRewardSetting")]
	public class DailyRewardSetting : ScriptableObject
	{
		public int[] range;

		public Sprite[] mainSprite;

		public Sprite[] iconSprite;

		public GameObject lightObj;

		public Color glassColor1;

		public Color glassColor2;
	}
}
