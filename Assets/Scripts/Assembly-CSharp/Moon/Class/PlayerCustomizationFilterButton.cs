using SVGImporter;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Class
{
	public class PlayerCustomizationFilterButton : UIButton
	{
		[SerializeField]
		private SVGImage _bg;

		[SerializeField]
		private SVGAsset _activeBg;

		[SerializeField]
		private Color _activeBgColor;

		[SerializeField]
		private SVGAsset _inactiveBg;

		[SerializeField]
		private Color _inactiveBgColor;

		[SerializeField]
		private Graphic _buttonGraphic;

		[SerializeField]
		private Color _activeGraphicColor;

		[SerializeField]
		private Color _inactiveGraphicColor;

		public void ShowAsSelected()
		{
		}

		public void ShowAsDeselected()
		{
		}
	}
}
