using System;
using DG.Tweening;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaScreenMesh : MonoBehaviour
	{
		[Serializable]
		private class MaxGoalTexture
		{
			public int GoalLimit;

			public Texture2D Texture2D;
		}

		private static readonly int _screenOn;

		private static readonly int _maskColorInt;

		private static readonly int _clockCountdown;

		private static readonly int _countdownOn;

		private static readonly int _countdown;

		private static readonly int _countdownNum;

		private static readonly int _scoringMode;

		private static readonly int _scoreTexture;

		private static readonly int _scoreTeamOne;

		private static readonly int _scoreTeamTwo;

		[SerializeField]
		private MeshRenderer _screenMesh;

		[SerializeField]
		private MaxGoalTexture[] _goalTextures;

		private Sequence _goalFxSequence;

		private Tween _overTimeEnteredTween;

		private float _cachedMaxGoalsFill;

		private MaxGoalTexture _curMaxGoalTexture;

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		public void ShowEmpty()
		{
		}

		public void PrepareForTimedMode()
		{
		}

		public void PrepareForMaxGoals(int maxGoals)
		{
		}

		public void SetMaxGoalsTeamOneScore(int score)
		{
		}

		public void SetMaxGoalsTeamTwoScore(int score)
		{
		}

		public void SetTimedModeCountdownOn(int remainingFinalCountdownTime, float countdownFill)
		{
		}

		public void SetTimedModeCountdownOff()
		{
		}

		public void SetTimedModeClockCountdown(float clockCountdownFill)
		{
		}

		public void TimedModeTweenClockCountdown(float target, float duration, Action onCompleteAction)
		{
		}

		private void ToggleScreen(bool on)
		{
		}

		public void KillOvertimeEnteredTween()
		{
		}

		public void PlayGoalFx(float goalFxAnimateInDuration, float goalFxAnimateOutDuration, float goalFxAnimateOutDelay)
		{
		}

		public void StopGoalFx()
		{
		}
	}
}
