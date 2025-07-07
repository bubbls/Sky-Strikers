using DP.Takeaway.Game;
using TMPro;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialChallengeRunningTrackManager : TutorialChallenge
	{
		[Header("Running Track Challenge Config")]
		[SerializeField]
		private Trigger _startPointTrigger;

		[SerializeField]
		private Trigger _endPointTrigger;

		[Header("Time Config")]
		[SerializeField]
		private float _challengeDuration;

		[SerializeField]
		private TMP_Text _timerText;

		private const string FailedChallengeText = "FAILED!";

		private const string SucceedChallengeText = "FINISHED:";

		private float _challengeTimer;

		private bool _startCountDown;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnStartPointTriggerEnter(Collider other)
		{
		}

		private void HandleOnEndPointTriggerEnter(Collider other)
		{
		}

		public override void StartChallenge()
		{
		}

		public override void SucceedChallenge()
		{
		}

		public override void FailedChallenge()
		{
		}

		public override void ResetChallenge()
		{
		}

		protected override void HandleBackToIdle()
		{
		}

		private void Update()
		{
		}
	}
}
