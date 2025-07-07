using System.Collections.Generic;
using Fusion;
using Moon.Leaderboard;
using UnityEngine;

namespace Moon
{
	public class PlayerStatsFrameManager : MonoBehaviour
	{
		[SerializeField]
		private List<PlayerStatsFrame> _teamOnePlayerStatsFrames;

		[SerializeField]
		private List<PlayerStatsFrame> _teamTwoPlayerStatsFrames;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateTeamOneFlags(PlayerRef[] playerRefs)
		{
		}

		public void UpdateTeamTwoFlags(PlayerRef[] playerRefs)
		{
		}

		private void SetPlayerStatsFrame(PlayerRef[] playerRefs, List<PlayerStatsFrame> playerStatsFrames)
		{
		}
	}
}
