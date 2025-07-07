using Moon.Hub;
using SVGImporter;
using UnityEngine;

namespace Moon.Shop
{
	public class DailyRewardClaimBtn : MonoBehaviour
	{
		[SerializeField]
		private SVGRenderer _svgRenderer;

		[SerializeField]
		private CanvasGroup _group;

		[SerializeField]
		private BoxCollider _collider;

		[SerializeField]
		private PushLockButton _lockBtn;

		[SerializeField]
		private GameObject _juiceBtnBg;

		public void SetClaiming(bool claiming, bool disable)
		{
		}

		public void HideJuiceBtnBg(bool hide)
		{
		}
	}
}
