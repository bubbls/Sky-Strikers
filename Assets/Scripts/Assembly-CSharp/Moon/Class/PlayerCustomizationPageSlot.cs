using System;
using System.Runtime.CompilerServices;
using Moon.Arena;
using SVGImporter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Class
{
	[RequireComponent(typeof(UIButton))]
	public class PlayerCustomizationPageSlot : MonoBehaviour
	{
		[SerializeField]
		private SVGImage[] _coloredFrameImages;

		[SerializeField]
		private SVGImage[] _backgrounds;

		[SerializeField]
		private float _inactiveFrameAlpha;

		[SerializeField]
		private float _inactiveBgAlpha;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TMP_Text _nameText;

		private PlayerCustomizationPageSlotData _slotData;

		private GameObject _targetVisual;

		private GameObject _loadedVisual;

		private UIButton _uiButton;

		private Color _targetColor;

		public event Action<PlayerCustomizationPageSlotData> OnSlotSelected
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

		private void UIButton_OnButtonPressed()
		{
		}

		public void ShowSlot(PlayerCustomizationPageSlotData slotData, TeamNo teamNo)
		{
		}

		public void HideSlot()
		{
		}

		public void UpdateTeamColor(TeamNo teamNo)
		{
		}

		private void ToggleSelected(bool isSelected)
		{
		}

		public void TrySelect(PlayerVisualsConfig visualsConfig)
		{
		}
	}
}
