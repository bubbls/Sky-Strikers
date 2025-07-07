using Moon.Hub;
using SVGImporter;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadNavigationButton : MonoBehaviour
	{
		[SerializeField]
		private ManualButton _manualButton;

		[SerializeField]
		private SVGRenderer _svg;

		[SerializeField]
		private Color _enabledTextColor;

		[SerializeField]
		private Color _disabledTextColor;

		public ManualButton ManualButton => null;

		public void ToggleButton(bool isEnabled)
		{
		}
	}
}
