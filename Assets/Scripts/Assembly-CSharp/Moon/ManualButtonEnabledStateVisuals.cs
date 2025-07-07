using System;
using DP.Takeaway.Runtime;
using Moon.Hub;
using TMPro;
using UnityEngine;

namespace Moon
{
	public class ManualButtonEnabledStateVisuals : MonoBehaviour
	{
		[Serializable]
		private class StateConfig
		{
			[Serializable]
			public class TextColors : SerializableDictionary<TMP_Text, Color>
			{
			}

			public GameObject[] ObjectsToToggle;

			public TextColors StateActiveTextColors;
		}

		[SerializeField]
		private ManualButton _manualButton;

		[SerializeField]
		[Space(5f)]
		private StateConfig _onStateConfig;

		[Space(5f)]
		[SerializeField]
		private StateConfig _offStateConfig;

		private void Start()
		{
		}

		private void ManualButton_OnEnabled()
		{
		}

		private void ToggleState(in StateConfig stateConfig, bool enable)
		{
		}
	}
}
