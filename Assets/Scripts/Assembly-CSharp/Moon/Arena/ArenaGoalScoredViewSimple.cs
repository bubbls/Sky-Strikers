using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaGoalScoredViewSimple : ArenaScreenView, IGoalScoredView
	{
		[SerializeField]
		protected TMP_Text _playerNameText;

		[SerializeField]
		private TMP_ColorGradient _teamOneGradient;

		[SerializeField]
		private TMP_ColorGradient _teamTwoGradient;

		[SerializeField]
		private TMP_Text _scoredText;

		[SerializeField]
		private float _screenScaleUpDuration;

		[SerializeField]
		private float _screenScaleDownDelay;

		[SerializeField]
		private float _screenScaleDownDuration;

		private Sequence _effectsSequence;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		protected override void EnterViewInternal(object viewData = null)
		{
		}

		private void PlaySequence(object viewData)
		{
		}

		protected override void ExitViewInternal()
		{
		}

		private void KillSequence()
		{
		}

		private void ConfigureText(ref TMP_Text targetText, string text, TMP_ColorGradient gradient)
		{
		}
	}
}
