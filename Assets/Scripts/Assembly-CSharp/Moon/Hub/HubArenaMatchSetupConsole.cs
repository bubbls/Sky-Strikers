using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Hub
{
	public class HubArenaMatchSetupConsole : MonoBehaviour
	{
		[Serializable]
		private class MatchSettingGroup
		{
			[SerializeField]
			private Transform _buttonParent;

			private List<Button> _buttons;

			public string CurOption { get; private set; }

			public void AddButtons<T>(T[] options, Button buttonPrefab, T defaultOption)
			{
			}

			private void SelectButton(string option)
			{
			}
		}

		[SerializeField]
		private MatchSettingGroup _matchTypeButton;

		[SerializeField]
		private MatchSettingGroup _ballTypeButton;

		[SerializeField]
		private MatchSettingGroup _ballModifierButton;

		[SerializeField]
		private MatchSettingGroup _platformLayoutButton;

		[SerializeField]
		private MatchSettingGroup _groundItemsButton;

		[SerializeField]
		private MatchSettingGroup _goalTypeButton;

		[SerializeField]
		private MatchSettingGroup _ammoMultiplierButton;

		[SerializeField]
		private Button _buttonObj;

		[SerializeField]
		private Button _applyButton;

		[SerializeField]
		private Button _endCurrentMatchButton;

		[SerializeField]
		private MHubArenaGameManager _gameManager;

		private void Start()
		{
		}

		private void ApplySettings()
		{
		}

		private void EndCurrentMatch()
		{
		}
	}
}
