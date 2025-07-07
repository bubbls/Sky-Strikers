using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.Class;
using Moon.Leaderboard;
using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon
{
	public class PlayerStatsBoard : MonoBehaviour
	{
		[SerializeField]
		private List<PlayerStatsBoardPage> _pages;

		[SerializeField]
		[Header("Navigation")]
		private PlayerCustomizationNavigationPanel _navigationPanel;

		[SerializeField]
		private PlayerStatsBoardSwitchButton _switchButton;

		[SerializeField]
		private TMP_Text _lastUpdatedTimeText;

		private IMessageSubscriber[] _subscribers;

		private const int MaxPages = 3;

		private bool _hasFetchedPlayerStats;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnSwitchButtonPressed()
		{
		}

		private int HandleOnLocalPlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private void HandleOnForwardButtonPressed()
		{
		}

		private void HandleOnBackButtonPressed()
		{
		}

		private void HandleOnPageChanged()
		{
		}

		private int HandleOnPlayerRankedStatisticsUpdated(IMessage<PlayerRankedStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private void UpdateCurrentPageData()
		{
		}
	}
}
