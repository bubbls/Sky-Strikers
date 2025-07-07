using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	public class InputBox : MonoBehaviour
	{
		private enum Style
		{
			DisplayScreen = 0,
			Light = 1
		}

		[SerializeField]
		private Style _style;

		[SerializeField]
		private InputBoxCharacter[] _inputBoxes;

		[SerializeField]
		private string _placeHolderChar;

		[SerializeField]
		[EnableIf("_style", Style.Light)]
		private Color _onColor;

		[EnableIf("_style", Style.Light)]
		[SerializeField]
		private Color _offColor;

		[SerializeField]
		private string _content;

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void DeleteOneChar()
		{
		}

		public void Clear()
		{
		}

		private void UpdateVisual()
		{
		}

		private void UpdateLight()
		{
		}

		private void UpdateDisplayScreen()
		{
		}
	}
}
