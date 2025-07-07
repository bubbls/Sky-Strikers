using Chamber8.Framework.Messaging;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class ScoreViewTimedModeHandler : ScoreViewTimedModeHandlerBase
	{
		[SerializeField]
		private ArenaScreenMesh _arenaScreenMesh;

		[SerializeField]
		private TMP_Text _infoText;

		[SerializeField]
		private GameObject _overtimeText;

		private int _remainingFinalCountdownTime;

		private float _remainingTime;

		private float _startFillTime;

		private float _oneSecondFill;

		private int _currentTimerDuration;

		private bool _canUpdateProgressIndicator;

		private bool _isViewActive;

		private IMessageSubscriber _matchEventsMessageSubscription;

		private MatchEventMessage _payload;

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

		private void LateUpdate()
		{
		}

		private void UpdateFinalCountdown()
		{
		}

		public override void HandleOnViewExited()
		{
		}
	}
}
