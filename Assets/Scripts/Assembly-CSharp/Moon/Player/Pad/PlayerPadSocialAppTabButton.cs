using System;
using System.Runtime.CompilerServices;
using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialAppTabButton : MonoBehaviour
	{
		[SerializeField]
		private string _tabName;

		[SerializeField]
		private UIButton _button;

		[SerializeField]
		private TMP_Text _buttonText;

		[SerializeField]
		private SVGImage _svgImage;

		[SerializeField]
		private SVGAsset _selectedSVG;

		[SerializeField]
		private SVGAsset _unselectedSVG;

		[SerializeField]
		private Color _selectedTextColor;

		[SerializeField]
		private Color _unselectedTextColor;

		private bool _isSelected;

		public event Action OnButtonPressed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialize()
		{
		}

		public void ToggleInteraction(bool enable)
		{
		}

		public void ToggleSelected(bool isSelected)
		{
		}

		public void UpdateText(int amount)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnButtonPressed()
		{
		}
	}
}
