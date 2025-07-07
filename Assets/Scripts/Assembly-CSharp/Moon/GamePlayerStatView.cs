using System.Collections.Generic;
using System.Text;
using Chamber8.Framework.Messaging;
using Moon.Hub;
using Moon.Leaderboard;
using TMPro;
using UnityEngine;

namespace Moon
{
	public class GamePlayerStatView : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _rankedStats;

		[SerializeField]
		private TMP_Text _lastMatchStats;

		[SerializeField]
		private ManualButton _rank1;

		[SerializeField]
		private ManualButton _rank2;

		[SerializeField]
		private ManualButton _rank3;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private int _rankIndex;

		private StringBuilder _stringBuilder;

		private bool _inited;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private int HandlePlayerStatisticsUpdated(IMessage<PlayerStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerRankedStatisticsUpdated(IMessage<PlayerRankedStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerRankedStatisticsUpdated(IMessage<PlayerLastMatchStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private void DisplayRankedStatsOne()
		{
		}

		private void DisplayRankedStatsTwo()
		{
		}

		private void DisplayRankedStatsThree()
		{
		}

		private void RefreshDisplayRankedStatsContent()
		{
		}

		private void RefreshDisplayLastMatchStatsContent(PlayerLastMatchStatistics lastMatchStatistics)
		{
		}

		private void RefreshDisplayRankedStatsOneContent()
		{
		}

		private void RefreshDisplayRankedStatsTwoContent()
		{
		}

		private void RefreshDisplayRankedStatsThreeContent()
		{
		}
	}
}
