using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.Player;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.MultiPlay
{
	public class RankedPairMatchmakingConsoleVisual : MonoBehaviour
	{
		[SerializeField]
		private GameObject _onlineUI;

		[SerializeField]
		private GameObject _offlineUI;

		[SerializeField]
		private TMP_Text _offlineText;

		[SerializeField]
		[Header("Ranked Pair Players In Queue UI")]
		private List<RankedPairPlayersInQueueEntry> _rankedPairPlayersInQueueEntries;

		[SerializeField]
		[Header("Slot UI")]
		private RankedPairMatchmakingConsoleSlotVisual _slotOneVisual;

		[SerializeField]
		private RankedPairMatchmakingConsoleSlotVisual _slotTwoVisual;

		[Header("Center UI")]
		[SerializeField]
		private GameObject _connectorUI;

		[SerializeField]
		private GameObject _pairSucceedUI;

		[SerializeField]
		private Image _timerFill;

		[SerializeField]
		private TMP_Text _messageText;

		[SerializeField]
		private TMP_Text _countDownText;

		[SerializeField]
		private Color _cantPairColor;

		[SerializeField]
		private Color _idleColor;

		[SerializeField]
		[Header("Notification")]
		private NotificationMessage _notificationMessage;

		private const string Offline = "OFFLINE";

		private const string FetchingData = "FETCHING DATA";

		private const string WaitingForPlayers = "WAITING FOR PLAYERS";

		private const string Full = "FULL";

		private const string Pairing = "PAIRING";

		private const string Preparing = "PREPARING";

		private const string CantPair = "RANK DISPARITY IS TOO LARGE";

		public event Action OnCancelRankedPairMatchmakingInQueue
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void InitializeVisuals()
		{
		}

		public void ToggleOnline(bool isOnline)
		{
		}

		public void SetFetchingDataState()
		{
		}

		public void UpdateRankedPairingSlotsUI(RankedPairMatchmakingSlotNetworkData rankedPairMatchmakingSlotOne, RankedPairMatchmakingSlotNetworkData rankedPairMatchmakingSlotTwo, PairConsoleState pairConsoleState)
		{
		}

		public void UpdateConnectorUI(float remainingTime, float fillAmount)
		{
		}

		private void SetPairingSlotsEmpty()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RankedPairPlayersInQueueEntry_HandleOnCancelButtonPressed()
		{
		}

		public void UpdateRankedPairPlayersEntry(NetworkRunner runner, int cooldownDuration, RankedPairPlayersNetworkData rankedPairPlayersNetworkData)
		{
		}

		private void ShowIdle()
		{
		}

		private void ShowPairingUI()
		{
		}

		private void ShowCantPairUI()
		{
		}
	}
}
