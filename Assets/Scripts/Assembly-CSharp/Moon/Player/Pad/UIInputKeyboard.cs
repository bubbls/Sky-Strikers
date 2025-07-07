using System.Collections.Generic;
using System.Text;
using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class UIInputKeyboard : MonoBehaviour
	{
		[SerializeField]
		private GameObject _container;

		[SerializeField]
		private TMP_Text _placeholderText;

		[SerializeField]
		private TMP_Text _inputText;

		[SerializeField]
		private int _inputNameMaxLength;

		[SerializeField]
		private List<UIInputKeyCode> _keyCodes;

		[SerializeField]
		private UIInputKeyboardButton _deleteButton;

		[SerializeField]
		private UIButton _shiftButton;

		[SerializeField]
		private SVGImage _shiftSvgImage;

		[SerializeField]
		private SVGAsset _shiftOnSVG;

		[SerializeField]
		private SVGAsset _shiftOffSVG;

		private readonly StringBuilder _inputStringBuilder;

		private bool _isUpperCase;

		public string InputName => null;

		public void ToggleUI(bool isShow)
		{
		}

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnShiftButtonPressed()
		{
		}

		private void HandleOnInputKeyCodePressed(string keyCode)
		{
		}

		private void HandleOnDeleteButtonPressed()
		{
		}
	}
}
