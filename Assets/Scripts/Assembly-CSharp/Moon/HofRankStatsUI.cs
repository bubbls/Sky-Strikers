using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.Leaderboard;
using TMPro;
using UnityEngine;

namespace Moon
{
	public class HofRankStatsUI : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _winStreakText;

		[SerializeField]
		private List<GameObject> _fires;

		[SerializeField]
		private GameObject _maxWinStreakVisual;

		private IMessageSubscriber[] _subscribers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void SetupFires(int winStreak)
		{
		}

		private int HandleOnLocalPlayerStatisticsUpdated(IMessage<PlayerStatisticsUpdatedMessage> message)
		{
			return 0;
		}
	}
}
