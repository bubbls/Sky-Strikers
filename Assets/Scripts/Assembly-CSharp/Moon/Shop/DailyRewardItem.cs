using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Shop
{
	public class DailyRewardItem : MonoBehaviour
	{
		public TMP_Text description;

		public Image mainIcon;

		public Image icon;

		public TMP_Text value;

		public CanvasGroup group;

		public void FlagClaimed(bool claimed)
		{
		}
	}
}
