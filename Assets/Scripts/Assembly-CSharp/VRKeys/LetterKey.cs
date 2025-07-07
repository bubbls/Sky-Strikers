using TMPro;
using UnityEngine;

namespace VRKeys
{
	public class LetterKey : Key
	{
		public TextMeshPro shiftedLabel;

		public string character;

		public string shiftedChar;

		private bool _shifted;

		public bool shifted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string GetCharacter()
		{
			return null;
		}

		public override void HandleTriggerEnter(Collider other)
		{
		}
	}
}
