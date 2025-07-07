using System;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class ScoreViewTimedModeHandlerSimple : ScoreViewTimedModeHandlerBase
	{
		[SerializeField]
		private TMP_Text _infoText;

		[SerializeField]
		private GameObject _timerContainer;

		[SerializeField]
		private GameObject _overtimeText;

		private TimeSpan _cachedTimeSpan;

		private float _elapsedTime;

		private float _finalCountdownStartTime;

		private int _currentTimerDuration;

		private IMessageSubscriber _matchEventsMessageSubscription;

		private MatchEventMessage _payload;

		private bool _isViewActive;

		private Cooldown _cd;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		private int HandleMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		public override void HandleOnViewEntered(object viewData)
		{
		}

		private void HandleOvertimeEntered()
		{
		}

		private void CalculateTimedModePrerequisites()
		{
		}

		private void SyncTimeToText()
		{
		}

		private void LateUpdate()
		{
		}

		public override void HandleOnViewExited()
		{
		}
	}
}
