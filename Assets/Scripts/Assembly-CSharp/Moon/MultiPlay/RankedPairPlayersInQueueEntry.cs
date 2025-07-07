using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.MultiPlay
{
	public class RankedPairPlayersInQueueEntry : MonoBehaviour
	{
		[SerializeField]
		private GameObject _emptySlot;

		[SerializeField]
		private GameObject _inQueueSlot;

		[SerializeField]
		private TMP_Text _playerOneName;

		[SerializeField]
		private TMP_Text _playerTwoName;

		[SerializeField]
		private Image _cooldownTimerFill;

		[SerializeField]
		private TMP_Text _cooldownTimerText;

		[SerializeField]
		private TMP_Text _entryTitleText;

		[SerializeField]
		private UIButton _cancelButton;

		private const string InQueue = "LOOKING FOR MATCH";

		private const string Cooldown = "COOLDOWN";

		public RankedPairState CurrentState { get; private set; }

		public event Action OnCancelButtonPressed
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

		public void SetEmptyState()
		{
		}

		private void Reset()
		{
		}

		private void UpdateEntry(string playerOneName, string playerTwoName, bool showCancelButton)
		{
		}

		public void SetState(RankedPairPlayersNetworkData rankedPairPlayersNetworkData)
		{
		}

		private void ShowCooldownTimer()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnCancelButtonPressed()
		{
		}

		public void UpdateCooldownTimerUI(int cooldownDuration, float? remainingTime)
		{
		}
	}
}
