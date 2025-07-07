using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon.PlayerProfile
{
	public abstract class PlayerAccoladeVisualizer : MonoBehaviour
	{
		[SerializeField]
		protected TMP_Text _statsText;

		public abstract void UpdateVisualizer(MPlayer mPlayer, PlayerInfo playerInfo);
	}
}
