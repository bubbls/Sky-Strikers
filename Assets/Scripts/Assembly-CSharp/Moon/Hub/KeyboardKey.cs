using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	[RequireComponent(typeof(ManualButton))]
	public class KeyboardKey : MonoBehaviour
	{
		[SerializeField]
		private string Content;

		[SerializeField]
		private TMP_Text _keyText;

		[SerializeField]
		private Color _enabledTextColor;

		[SerializeField]
		private Color _disabledTextColor;

		private ManualButton _manualButton;

		private bool _isInitialized;

		public event Action<string> OnKeyPressed
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

		private void TryInitialize()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleKeyPressed()
		{
		}

		public void ToggleInput(bool inputEnabled)
		{
		}
	}
}
