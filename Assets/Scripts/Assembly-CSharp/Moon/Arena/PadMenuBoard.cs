using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class PadMenuBoard : MonoBehaviour
	{
		private const string GeneralInstructionsText = "PRESS Y OR MENU BUTTON\nTO OPEN WPAD";

		private const string ValveIndexInstructionsText = "PRESS Y OR\nTOUCH MENU BUTTON TO OPEN WPAD";

		[SerializeField]
		private TMP_Text _instructionsText;

		private void Start()
		{
		}
	}
}
