using System;
using Moon.Arena;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class HubClassChangeMachine : MonoBehaviour
	{
		[Serializable]
		private class ButtonPair
		{
			[SerializeField]
			private RectTransform _container;

			public void Toggle(bool toggle)
			{
			}
		}

		[SerializeField]
		private ButtonPair _primeButtonPair;

		[SerializeField]
		private ButtonPair _jetstreamButtonPair;

		[SerializeField]
		private ButtonPair _bulwarpButtonPair;

		[SerializeField]
		private TMP_Text _titleText;

		[SerializeField]
		private TMP_Text _singleClassText;

		public void Configure(AllowedClasses allowedClasses)
		{
		}

		private static int CountFlags<T>(T enumValue) where T : Enum
		{
			return 0;
		}
	}
}
