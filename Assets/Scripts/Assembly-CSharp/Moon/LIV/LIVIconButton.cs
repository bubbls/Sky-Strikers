using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVIconButton : LIVButton
	{
		private enum IconMode
		{
			Asset = 0,
			Rotate = 1,
			Text = 2
		}

		[SerializeField]
		private IconMode _iconMode;

		[SerializeField]
		private SVGImage _icon;

		[SerializeField]
		private TMP_Text _text;

		[Header("Asset Mode")]
		[SerializeField]
		private SVGAsset _onIcon;

		[SerializeField]
		private SVGAsset _offIcon;

		[Header("Rotate Mode")]
		[SerializeField]
		private Vector3 _startRotation;

		[SerializeField]
		private Vector3 _targetRotation;

		[SerializeField]
		[Header("Text Mode")]
		private string _onText;

		[SerializeField]
		private string _offText;

		[SerializeField]
		private Color _textEnabledColor;

		[SerializeField]
		private Color _textDisabledColor;

		[Header("Interaction")]
		[SerializeField]
		private SVGAsset _enableIcon;

		[SerializeField]
		private SVGAsset _disableIcon;

		private bool _isPressed;

		protected override void UpdateInteractionVisuals(bool isEnabled)
		{
		}

		protected override void UpdateVisuals()
		{
		}
	}
}
