using DG.Tweening;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialChallengeShootTarget : TutorialShootTarget
	{
		[SerializeField]
		private float _leftXValue;

		[SerializeField]
		private float _rightXValue;

		[SerializeField]
		private float _moveDuration;

		private Sequence _sequence;

		public void StartMove()
		{
		}

		public override void OnHit()
		{
		}

		public void Reset()
		{
		}

		private void OnDestroy()
		{
		}

		private void KillSequence()
		{
		}
	}
}
