using Chamber8.Framework.Messaging;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaGoalScoredView : ArenaScreenView, IGoalScoredView
	{
		[SerializeField]
		private TeamNo _screenTeam;

		[SerializeField]
		protected TMP_Text _playerNameTextWithCam;

		[SerializeField]
		protected TMP_Text _playerNameTextNoCam;

		[SerializeField]
		private TMP_ColorGradient _teamOneGradient;

		[SerializeField]
		private TMP_ColorGradient _teamTwoGradient;

		[SerializeField]
		private Material _goalCamMaterial;

		[SerializeField]
		private ArenaScreenMesh _arenaScreenMesh;

		[SerializeField]
		[Header("Tween Config")]
		[Space(5f)]
		private float _goalEffectPlayDuration;

		[SerializeField]
		private float _screenScaleUpDuration;

		[SerializeField]
		private float _screenScaleDownDelay;

		[SerializeField]
		private float _screenScaleDownDuration;

		[SerializeField]
		private float _goalFxAnimateInDuration;

		[SerializeField]
		private float _goalFxAnimateOutDelay;

		[SerializeField]
		private float _goalFxAnimateOutDuration;

		private Sequence _effectsSequence;

		private IMessageSubscriber _messageSubscriber;

		[Header("Temporary")]
		[SerializeField]
		private GameObject _scoreView;

		[SerializeField]
		private TMP_Text _scorerName;

		[SerializeField]
		private TMP_Text _scored;

		[SerializeField]
		private TMP_Text _ballSpeedText;

		[SerializeField]
		private TMP_Text _shooterDistanceText;

		[SerializeField]
		private bool _useGoalCam;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		protected override void EnterViewInternal(object viewData = null)
		{
		}

		private void PlayOriginalEffectWithoutGoalCam(object viewData)
		{
		}

		private void PlayEffectWithGoalCam(object viewData)
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

		private string TruncateString(string input, int maxLength)
		{
			return null;
		}
	}
}
