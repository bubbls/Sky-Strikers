using DG.Tweening;
using SVGImporter;
using UnityEngine;

namespace Moon.Class
{
	public class PlayerCustomizationNavigationPanelButton : UIButton
	{
		[SerializeField]
		private SVGImage _bg;

		[SerializeField]
		private Color _activeBgColor;

		[SerializeField]
		private Color _inactiveBgColor;

		[SerializeField]
		private DOTweenAnimation _doTweenAnimation;

		protected override void HandleOnInteractionStateChanged(bool interactionEnabled)
		{
		}

		protected override void HandleOnButtonPressedInternal()
		{
		}
	}
}
