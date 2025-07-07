using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Moon.ReportingSystem;
using UnityEngine;

namespace Moon.Player.Pad
{
	public abstract class SettingsTurningOptionsGroup : MonoBehaviour
	{
		private struct ButtonMap
		{
			public int ButtonEnumValue;

			public KeyIndexedVisual Visual;
		}

		private const string VisualKeyOn = "on";

		private const string VisualKeyOff = "off";

		[SerializeField]
		private UIButton _mainButton;

		private KeyIndexedVisual _mainVisual;

		[SerializeField]
		private UIButton[] _optionButtons;

		private Dictionary<UIButton, ButtonMap> _indexedVisualsMap;

		public event Action OnMainButtonPressed
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

		public event Action<int> OnOptionSelected
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

		protected abstract Array GetEnumArray();

		private void Button_OnButtonPressed(UIButton button)
		{
		}

		public void SetMainButtonAsSelected()
		{
		}

		private void ToggleMainButtonVisual(bool selected)
		{
		}

		public void SelectButton(int enumValue)
		{
		}

		public void DisableAllButtons()
		{
		}
	}
}
