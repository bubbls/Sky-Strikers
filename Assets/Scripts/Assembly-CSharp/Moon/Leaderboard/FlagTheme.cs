using Fusion;
using Moon.GameActivity;
using UnityEngine;

namespace Moon.Leaderboard
{
	public abstract class FlagTheme : MonoBehaviour
	{
		[SerializeField]
		private FlagThemeLocation _flagThemeLocation;

		protected FlagThemeLocation FlagThemeLocation => default(FlagThemeLocation);

		public void UpdateThemeVisual(PlayerRef playerRef)
		{
		}

		public void UpdateThemeVisual(FlagFrameConfiguration configuration)
		{
		}

		protected abstract void UpdateThemeVisualInternal(FlagFrameConfiguration configuration);
	}
}
