using JetBrains.Annotations;
using Moon.PlayerProfile;
using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	public class MMRSimulateTool : MonoBehaviour
	{
		[SerializeField]
		private MatchResult _matchResult;

		[SerializeField]
		private int _mmr;

		[SerializeField]
		[Header("Match Time")]
		private int _totalPlayTime;

		[SerializeField]
		[Header("Forfeit")]
		private bool _isForfeit;

		[Header("Underdog")]
		[SerializeField]
		private bool _isUnderdog;

		[SerializeField]
		[Header("WinStreak")]
		private int _winStreak;

		[SerializeField]
		private int _highestWinStreak;

		[SerializeField]
		[Header("Leaver")]
		private bool _hasLeaverInTeam;

		[SerializeField]
		private bool _isLeaver;

		[SerializeField]
		private int _leaverLever;

		[Button("Simulate Match Complete", EButtonEnableMode.Always)]
		[UsedImplicitly]
		private void SimulateMatchComplete()
		{
		}
	}
}
