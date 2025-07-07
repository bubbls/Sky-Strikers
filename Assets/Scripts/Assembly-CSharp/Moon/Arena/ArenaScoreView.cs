using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaScoreView : ArenaScreenView
	{
		[SerializeField]
		protected TMP_Text _teamOneScoreText;

		[SerializeField]
		protected TMP_Text _teamTwoScoreText;

		[SerializeField]
		private TMP_Text _infoText;

		[SerializeField]
		protected ScoreViewTimedModeHandlerBase _timedModeHandler;

		[SerializeField]
		protected ScoreViewMaxGoalsHandlerBase _maxGoalsModeHandler;

		[SerializeField]
		private ArenaScreenMesh _arenaScreenMesh;

		protected IScoreViewGameModeHandler _currGameModeHandler;

		private object _viewData;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		private void ArenaSharedData_OnHasInitialSync()
		{
		}

		protected override void EnterViewInternal(object viewData = null)
		{
		}

		protected virtual void UpdateViewForCurrentGameStatus(object viewData)
		{
		}

		protected override void ExitViewInternal()
		{
		}
	}
}
