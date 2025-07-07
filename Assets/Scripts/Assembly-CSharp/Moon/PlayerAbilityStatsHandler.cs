using System.Collections.Generic;
using Fusion;
using Moon.Arena;
using Moon.Framework.Leaderboard;
using Moon.MultiPlay;

namespace Moon
{
	public class PlayerAbilityStatsHandler : PlayerStatsHandler
	{
		private class PlayerAbilityStat
		{
			public int DisplaceDone;

			public int DisplaceReceived;
		}

		private PlayerAbilityStat _abilityStat;

		public PlayerAbilityStatsHandler(PlayerRef playerRef, string playFabId, PlayerInfo playerInfo)
			: base(default(PlayerRef), null, default(PlayerInfo))
		{
		}

		public override void StartTracking()
		{
		}

		public override void StopTracking()
		{
		}

		public override void OnMatchPrepare()
		{
		}

		public override void HandlePlayerAbilityInflicted(PlayerAbilityMessageData playerAbilityMessageData)
		{
		}

		public List<Statistic> OperateStatsListOnMatchCompleted()
		{
			return null;
		}

		public void NotifyStatsUpdatedOnMatchCompleted()
		{
		}
	}
}
