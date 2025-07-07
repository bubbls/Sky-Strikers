using UnityEngine;

namespace Moon.Leaderboard
{
	public class PlayerNameBoard : FlagTheme
	{
		[SerializeField]
		private Transform _playerNameText;

		protected override void UpdateThemeVisualInternal(FlagFrameConfiguration configuration)
		{
		}
	}
}
