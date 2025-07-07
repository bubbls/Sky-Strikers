using System.Collections.Generic;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Arena
{
	public class RankedArenaSoundPlayer : MonoBehaviour
	{
		[SerializeField]
		private SoundInfo _waitingForPlayersSfx;

		[SerializeField]
		private SoundInfo _teamPreparationStartSfx;

		[SerializeField]
		private SoundInfo _teamPreparationTenSecWarningSfx;

		[SerializeField]
		private SoundInfo _teamPreparationFiveSecWarningSfx;

		[SerializeField]
		private SoundInfo _matchStartingSfx;

		[SerializeField]
		private SoundInfo _teamOneWinningSfx;

		[SerializeField]
		private SoundInfo _teamTwoWinningSfx;

		[SerializeField]
		private SoundInfo _drawSfx;

		[SerializeField]
		private SoundInfo _arenaClosingWarning;

		[SerializeField]
		private SoundInfo _arenaClosingTenSecWarning;

		[SerializeField]
		private SoundInfo _arenaClosingFiveSecWarning;

		[SerializeField]
		private SoundInfo _arenaPlayerLeftSfx;

		private List<int> _timerIds;

		private int _waitingForPlayersDelayId;

		private int _waitingForPlayersSoundId;

		public void ResetSoundPlayer()
		{
		}

		private void OnDisable()
		{
		}

		public void PlayWaitingForPlayersSfx(float delay)
		{
		}

		public void CancelWaitingForPlayersSfx()
		{
		}

		public void PlayAndQueueTeamPreparationSounds(float remainingTime)
		{
		}

		public void QueueMatchStartingSfx(float remainingTime)
		{
		}

		public void PlayWinningTeamSfx(TeamNo winningTeam)
		{
		}

		public void PlayPlayerLeftSfx()
		{
		}

		public void PlayAndQueueArenaClosingSounds(float remainingTime)
		{
		}

		private int PlaySound(SoundInfo soundInfo)
		{
			return 0;
		}
	}
}
