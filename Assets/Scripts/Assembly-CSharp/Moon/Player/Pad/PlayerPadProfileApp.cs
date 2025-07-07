using Chamber8.Framework.Messaging;
using Moon.Leaderboard;
using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadProfileApp : PlayerPadApp
	{
		[SerializeField]
		private PlayerPadProfileSummaryPage _summaryPage;

		[SerializeField]
		private TMP_Text _lastUpdatedTimeText;

		private IMessageSubscriber[] _subscribers;

		private bool _hasFetchedPlayerStats;

		public override PlayerPadAppID AppID => default(PlayerPadAppID);

		protected override void InitializeInternal()
		{
		}

		protected override void HandleAppAboutToOpenInternal(IPlayerPadAppOpenData appOpenData)
		{
		}

		protected override void HandleAppAboutToCloseInternal()
		{
		}

		private int HandleOnLocalPlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private int HandleOnPlayerRankedStatisticsUpdated(IMessage<PlayerRankedStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private void UpdateCurrentPageData(bool force)
		{
		}
	}
}
