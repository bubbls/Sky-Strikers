using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Shop
{
	public class DailyRewardClaimPanel : MonoBehaviour
	{
		[SerializeField]
		private Image _mainIcon;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TMP_Text _amount;

		public void SetClaimPanel(Sprite main, Sprite icon, string value)
		{
		}
	}
}
