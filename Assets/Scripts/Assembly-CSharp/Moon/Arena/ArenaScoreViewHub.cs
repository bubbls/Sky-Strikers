using UnityEngine;

namespace Moon.Arena
{
	public class ArenaScoreViewHub : ArenaScoreView
	{
		[SerializeField]
		private GameObject _freePlayModeView;

		[SerializeField]
		private GameObject _matchModeView;

		protected override void UpdateViewForCurrentGameStatus(object viewData)
		{
		}
	}
}
