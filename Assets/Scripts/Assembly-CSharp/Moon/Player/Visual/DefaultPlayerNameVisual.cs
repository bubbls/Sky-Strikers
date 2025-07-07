using TMPro;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class DefaultPlayerNameVisual : PlayerNameVisual
	{
		[SerializeField]
		private TMP_Text[] _textMeshes;

		public override void SetPlayerName(string playerName)
		{
		}
	}
}
