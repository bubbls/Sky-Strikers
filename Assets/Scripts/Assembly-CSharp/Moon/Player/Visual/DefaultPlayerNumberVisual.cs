using TMPro;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class DefaultPlayerNumberVisual : PlayerNumberVisual
	{
		[SerializeField]
		private TMP_Text[] _textMeshes;

		public override void SetPlayerNumber(int number)
		{
		}
	}
}
