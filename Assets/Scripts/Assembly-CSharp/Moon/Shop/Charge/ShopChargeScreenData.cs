using System;
using SVGImporter;
using UnityEngine;

namespace Moon.Shop.Charge
{
	[Serializable]
	public class ShopChargeScreenData
	{
		[SerializeField]
		[TextArea]
		private string _message;

		[SerializeField]
		private SVGAsset _iconSvg;

		[SerializeField]
		private ShopChargeScreenStatus _status;

		[SerializeField]
		private Sprite _iconSprite;

		public string Message => null;

		public SVGAsset IconSvg => null;

		public ShopChargeScreenStatus Status => default(ShopChargeScreenStatus);

		public Sprite IconSprite => null;
	}
}
